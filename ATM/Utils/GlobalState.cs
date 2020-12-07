using System.Collections.Generic;

namespace ATM
{
    public class GlobalState
    {
        private static GlobalState _instance;
        private readonly Dictionary<string, bool> _booleanState;
        private readonly Dictionary<string, int> _intState;
        private readonly Dictionary<string, string> _stringState;

        public GlobalState()
        {
            _stringState = new Dictionary<string, string>();
            _intState = new Dictionary<string, int>();
            _booleanState = new Dictionary<string, bool>();
        }

        public static GlobalState GetInstance()
        {
            if (_instance == null) _instance = new GlobalState();

            return _instance;
        }

        public void SetString(string key, string v)
        {
            if (_stringState.ContainsKey(key))
            {
                _stringState[key] = v;
                return;
            }
            _stringState.Add(key, v);
        }

        public string GetString(string key)
        {
            if (!_stringState.ContainsKey(key)) _stringState.Add(key, "");
            return _stringState[key];
        }

        public void SetInt(string key, int v)
        {
            if (_intState.ContainsKey(key))
            {
                _intState[key] = v;
                return;
            }
            _intState.Add(key, v);
        }

        public int GetInt(string key)
        {
            if (!_intState.ContainsKey(key)) _intState.Add(key, 0);
            return _intState[key];
        }

        public void SetBoolean(string key, bool v)
        {
            if (_booleanState.ContainsKey(key))
            {
                _booleanState[key] = v;
                return;
            }
            _booleanState.Add(key, v);
        }

        public bool GetBoolean(string key)
        {
            if (!_booleanState.ContainsKey(key)) _booleanState.Add(key, false);
            return _booleanState[key];
        }
    }
}