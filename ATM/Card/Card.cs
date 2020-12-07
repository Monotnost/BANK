using System;
using System.IO;
using System.Xml.Serialization;

namespace ATM.Card
{
    public class Card
    {
        private static Setting[] _settings;
        private int[] _number;

        static Card()
        {
            loadSetting("bank.xml");
        }

        public Card(int[] number)
        {
            SetNumber(number);
        }

        public Card(string number)
        {
            SetNumber(ConvertNumberToArray(number));
        }

        public static void loadSetting(string path)
        {
            var formatter = new XmlSerializer(typeof(Setting[]));
            using (var fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                _settings = (Setting[]) formatter.Deserialize(fs);
            }
        }

        public static int[] ConvertNumberToArray(string number)
        {
            var n = 0;
            var posithion = 0;
            for (var i = 0; i < number.Length; i++)
                if (number[i] <= '9' && number[i] >= '0')
                    n++;

            var array = new int[n];
            for (var i = 0; i < number.Length; i++)
                if (number[i] <= '9' && number[i] >= '0')
                {
                    array[posithion] = (int) char.GetNumericValue(number[i]);
                    posithion++;
                }

            return array;
        }

        public static string ConvertNumberToString(int[] array)
        {
            var charArray = new char[array.Length];
            for (var i = 0; i < array.Length; i++) charArray[i] = (char) (array[i] + '0');

            return new string(charArray);
        }

        public static bool ValidateCreditCard(int[] number)
        {
            var sum = 0;
            var alt = true;
            for (var i = number.Length - 1; i >= 0; i--)
            {
                if (alt)
                {
                    sum += number[i];
                }
                else
                {
                    var digit = number[i] * 2;
                    while (digit > 0)
                    {
                        sum += digit % 10;
                        digit /= 10;
                    }
                }

                alt = !alt;
            }

            var validated = sum % 10 == 0;
            return validated;
        }

        public static bool ValidateCreditCard(string number)
        {
            return ValidateCreditCard(ConvertNumberToArray(number));
        }

        public string GetNumber()
        {
            return ConvertNumberToString(_number);
        }

        private void SetNumber(int[] number)
        {
            if (ValidateCreditCard(number) == false) throw new ArgumentException("INVALID CARD NUMBER");

            if (GetBank(ConvertNumberToString(number)) == null) throw new ArgumentException("INVALID BANK");

            _number = number;
        }

        public string GetBank()
        {
            return GetBank(ConvertNumberToString(_number));
        }

        public static string GetBank(string number)
        {
            var numberArray = ConvertNumberToArray(number);
            foreach (var s in _settings)
            {
                if (numberArray.Length < s.minLen || numberArray.Length > s.maxLen) continue;

                foreach (var num in s.firstNumbers)
                    if (number.Substring(0, num.Length) == num)
                        return s.name;
            }

            return null;
        }

        public override string ToString()
        {
            return GetBank() + '\n' + ConvertNumberToString(_number);
        }
    }
}