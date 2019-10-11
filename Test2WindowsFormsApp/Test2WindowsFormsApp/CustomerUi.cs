using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test2WindowsFormsApp.Model;
using Test2WindowsFormsApp.BLL;
namespace Test2WindowsFormsApp
{
    public partial class CustomerUi : Form
    {
        CustomerManager _customerManager = new CustomerManager();
        public CustomerUi()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                Customer customer = new Customer();





                if (String.IsNullOrEmpty(accountnoTextBox.Text) || accountnoTextBox.Text.Length != 8)
                {
                    MessageBox.Show("Account number should have 8 digits");
                    return;
                }

                customer.AccountNo = Convert.ToInt32(accountnoTextBox.Text);

                if (_customerManager.IsAccountExists(customer))
                {
                    MessageBox.Show(accountnoTextBox.Text + " Already Exists!");
                    return;
                }

                customer.Name = nameTextBox.Text;



                customer.Email = mailTextBox.Text;

                customer.Date = dateTextBox.Text;

                if (_customerManager.Add(customer))
                {
                    MessageBox.Show("Data Saved");
                }
                else
                {
                    MessageBox.Show("Save Error");
                }
            }
            catch(Exception exception)
            {
                MessageBox.Show("Error");
            }

        }
    }
}
