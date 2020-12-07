using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace ATM.Database
{
    public class Database
    {
        private static Database _instance;
        private readonly string _path;

        public Database(string path)
        {
            _path = path;
            _accounts = new List<Account>();
            Load();
        }

        private List<Account> _accounts { get; set; }

        public static Database GetInstance()
        {
            if (_instance == null) _instance = new Database("./data1.xml");
            return _instance;
        }

        public void Save()
        {
            Stream xmlInputStream = new FileStream(_path, FileMode.Create);
            var serializer = new XmlSerializer(typeof(List<Account>));
            serializer.Serialize(xmlInputStream, _accounts);
            xmlInputStream.Close();
        }

        public void Load()
        {
            Stream xmlInputStream = new FileStream(_path, FileMode.Open);
            var deserializer = new XmlSerializer(typeof(List<Account>));
            _accounts = (List<Account>) deserializer.Deserialize(xmlInputStream);
            xmlInputStream.Close();
        }

        public void AddAccount(Account account)
        {
            var exist = _accounts.Find(o => o.CardNumber == account.CardNumber);
            if (exist != null) throw new Exception("Account already exist");
            _accounts.Add(account);
        }

        public Account GetAccount(string cardNumber)
        {
            return _accounts.Find(o => o.CardNumber == cardNumber);
        }
    }
}