using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexApp
{
    internal class Program
    {
        public static List<string> ReadLinesFromFile(string path)
        {
            List<string> result;
            result = File.ReadLines(path).ToList();
            return result;
        }

        public static List<string> SplitToWords(string line)
        {
            List<string> words = new List<string>();
            Regex rx = new Regex(@"[а-яА-Яa-zA-Z]+",
                RegexOptions.Compiled | RegexOptions.IgnoreCase);
            MatchCollection matches = rx.Matches(line);
            foreach (Match match in matches)
            {
                words.Add(match.Value.ToLower());
            }

            return words;
        }

        public static Dictionary<string, HashSet<int>> CreateDictinary(List<string> lines)
        {
            Dictionary<string, HashSet<int>> concordance = new Dictionary<string, HashSet<int>>();
            int page = 0;
            int index = 0;
            Dictionary<string, HashSet<int>> buffer = new Dictionary<string, HashSet<int>>();
            foreach (string line in lines)
            {
                if (index % 60 == 0)
                {
                    page++;
                    foreach (var value in buffer)
                    {
                        if (!concordance.ContainsKey(value.Key))
                        {
                            concordance[value.Key] = new HashSet<int>();
                        }

                        concordance[value.Key].Add(page);
                    }

                    buffer.Clear();
                }

                index++;
                foreach (string word in SplitToWords(line))
                {
                    if (!buffer.ContainsKey(word))
                    {
                        buffer[word] = new HashSet<int>();
                    }

                    buffer[word].Add(page);
                }
            }

            foreach (var value in buffer)
            {
                if (!concordance.ContainsKey(value.Key))
                {
                    concordance[value.Key] = new HashSet<int>();
                }

                concordance[value.Key].Add(page);
            }

            return concordance;
        }

        public static string CreateConcordance(Dictionary<string, HashSet<int>> dictionary)
        {
            StringBuilder sb = new StringBuilder();
            List<string> keys = dictionary.Keys.OrderBy(o => o).ToList();
            char lastChar = '0';

            foreach (string key in keys)
            {
                if (key[0] != lastChar)
                {
                    lastChar = key[0];
                    sb.AppendFormat("\n{0}\n", lastChar.ToString().ToUpper());
                }
                sb.AppendFormat(
                    "{0}{1}:{2}\n",
                    key.PadRight(30 - dictionary[key].Count.ToString().Length, '.'),
                    dictionary[key].Count,
                    String.Join(", ", dictionary[key])
                );
            }

            return sb.ToString();
        }

        public static void Main(string[] args)
        {
            Console.Write("Path: ");
            string path = Console.ReadLine();
            List<string> lines;
            try
            {
                lines = ReadLinesFromFile("text.txt");
            }
            catch
            {
                Console.WriteLine("Invalid path");
                return;
            }
            var dictionary = CreateDictinary(lines);
            string concordance = CreateConcordance(dictionary);
            File.WriteAllText("result.txt", concordance);
        }
    }
}