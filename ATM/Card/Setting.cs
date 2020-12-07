using System;

namespace ATM.Card
{
    [Serializable]
    public class Setting
    {
        public string[] firstNumbers;
        public int maxLen;
        public int minLen;
        public string name;
    }
}