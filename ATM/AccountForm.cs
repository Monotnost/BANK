using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ATM.Database;
using ATM.Utils;

namespace ATM
{
    public partial class AccountForm : Form
    {
        GlobalState _globalState = GlobalState.GetInstance();
        AccountService _accountService = new AccountService();
        Database.Database _database = Database.Database.GetInstance();

        Account _account;
        Banknotes _banknotes;

        public AccountForm()
        {
            InitializeComponent();
        }

        private void AccountForm_Load(object sender, EventArgs e)
        {
            _account = _database.GetAccount(_globalState.GetString("number"));
            _banknotes = Banknotes.GetInstance();
            UpdateInfo();
        }

        private void UpdateInfo()
        {
            balanceLable.Text = _account.Balance.ToString();
            nameLable.Text = _account.Name;
            cardNumberLable.Text = _account.CardNumber;
        }

        private void getBtn_Click(object sender, EventArgs e)
        {
            int ammount = -1;
            try
            {
                ammount = Int32.Parse(amountField.Text);
            }
            catch
            {
            }

            if (ammount <= 0 || ammount > _account.Balance)
            {
                MessageBox.Show("Invalid ammount");
                return;
            }

            Dictionary<int, int> banknotes = _banknotes.GetSum(ammount);
            if (banknotes == null)
            {
                MessageBox.Show("No banknotes");
                return;
            }

            _account.Balance -= ammount;
            amountField.Text = "";
            UpdateInfo();
            _database.Save();
            MessageBox.Show(
                String.Join(
                    ",\n",
                    banknotes
                        .Where(o => o.Value > 0)
                        .Select(o => o.Key.ToString() + "$ - " + o.Value.ToString()))
            );
        }

        private void AmountField_TextChanged(object sender, EventArgs e)
        {

        }
    }
}