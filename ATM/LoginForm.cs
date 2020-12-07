using System;
using System.Windows.Forms;

namespace ATM
{
    public partial class Form1 : Form
    {
        private AccountForm _accountForm = new AccountForm();
        private readonly AccountService _accountService = new AccountService();
        private readonly GlobalState _globalState = GlobalState.GetInstance();

        public Form1()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            var cardNumber = cardNumberField.Text;
            var pin = cvvField.Text;
            if (!_accountService.ValidateCardNumber(cardNumber))
            {
                MessageBox.Show("Invalid card number");
                return;
            }

            if (!_accountService.CheckPinCode(cardNumber, pin))
            {
                MessageBox.Show("Invalid pin");
                return;
            }

            _globalState.SetString("number", cardNumber);
            cvvField.Text = "";
            cardNumberField.Text = "";
            _accountForm = new AccountForm();
            _accountForm.Show();
        }

        private void LoginBtn_Click_1(object sender, EventArgs e)
        {
            var cardNumber = cardNumberField.Text;
            var pin = cvvField.Text;
            if (!_accountService.ValidateCardNumber(cardNumber))
            {
                MessageBox.Show("Invalid card number");
                return;
            }

            if (!_accountService.CheckPinCode(cardNumber, pin))
            {
                MessageBox.Show("Invalid pin");
                return;
            }

            _globalState.SetString("number", cardNumber);
            cvvField.Text = "";
            cardNumberField.Text = "";
            _accountForm = new AccountForm();
            _accountForm.Show();
        }
    }
}