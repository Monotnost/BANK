using System.Collections.Generic;
using System.Linq;

namespace ATM.Utils
{
    public class Banknotes
    {
        private Dictionary<int, int> _banknotes;

        private static Banknotes _instance = null;

        public static Banknotes GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Banknotes();
            }
            return _instance;
        }

        public Banknotes()
        {
            _banknotes = new Dictionary<int, int>();
            _banknotes.Add(5, 10);
            _banknotes.Add(10, 10);
            _banknotes.Add(20, 10);
            _banknotes.Add(50, 10);
            _banknotes.Add(100, 10);
        }

        public Dictionary<int, int> GetSum(int sum)
        {
            var list = new Dictionary<int, int>();
            var nominal = _banknotes.Keys.ToList();
            nominal.Sort();
            nominal.Reverse();
            int buf = 0;
            foreach (var i in nominal)
            {
                if (buf >= sum)
                {
                    break;
                }
                list[i] = 0;
                while (list[i] < _banknotes[i])
                {
                    if (buf + i > sum)
                    {
                        break;
                    }
                    buf += i;
                    list[i]++;
                }
            }

            if (buf != sum)
            {
                return null;
            }

            foreach (var i in list)
            {
                _banknotes[i.Key] -= i.Value;
            }
            return list;
        }
    }
}