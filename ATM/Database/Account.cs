namespace ATM.Database
{
    public class Account
    {
        public string Name { get; set; }
        public string CardNumber { get; set; }
        public string PinCode { get; set; }
        public int Balance { get; set; }

        public Account(string name, string cardNumber, string pinCode)
        {
            Name = name;
            CardNumber = cardNumber;
            PinCode = pinCode;
            Balance = 0;
        }

        public Account()
        {
        }
    }
}