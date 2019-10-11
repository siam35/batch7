using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test2WindowsFormsApp.BLL;
using Test2WindowsFormsApp.Model;
namespace Test2WindowsFormsApp
{
    public partial class TransactionUi : Form
    {
        AccountManager _accountManager = new AccountManager();
        public TransactionUi()
        {
            InitializeComponent();
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
           
                Account account = new Account();


                account.AccountNo = Convert.ToInt32(accountnoTextBox.Text);



                account.AccountNo = Convert.ToInt32(accountnoTextBox.Text);
                account.input = Convert.ToInt32(amountTextBox.Text);

                _accountManager.AddAmount(account);


                if (_accountManager.Update(account))
                {
                    MessageBox.Show("Amount Deposited");
                }
                else
                {
                    MessageBox.Show("Not Updated");
                }
            
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            Account account = new Account();


            account.AccountNo = Convert.ToInt32(accountnoTextBox.Text);
            account.input = Convert.ToInt32(amountTextBox.Text);
            if (_accountManager.WithUpdate(account))
            {
                MessageBox.Show("Amount Withdrawn");
            }
            else
            {
                MessageBox.Show("Not Updated");
            }

        }
    }
}
