using ATM.Database;

namespace ATM
{
    public class AccountService
    {
        private Database.Database _database;

        public AccountService()
        {
            _database  = Database.Database.GetInstance();
        }

        public bool ValidateCardNumber(string number)
        {
            if (Card.Card.ConvertNumberToArray(number).Length == 0)
            {
                return false;
            }
            Account account = _database.GetAccount(number);
            if (account == null)
            {
                return false;
            }
            return Card.Card.ValidateCreditCard(number);
        }

        public bool CheckPinCode(string cardNumber, string pin)
        {
            Account account = _database.GetAccount(cardNumber);
            if (account == null)
            {
                return false;
            }

            return account.PinCode == pin;
        }
    }
}