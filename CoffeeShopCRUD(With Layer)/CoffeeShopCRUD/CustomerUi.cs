using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoffeeShopCRUD.BLLitem;

namespace CoffeeShopCRUD
{
    public partial class CustomerUi : Form
    {
        CustomerManager _customerManager =new CustomerManager();
        public CustomerUi()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //Name unique check
            if (_customerManager.IsNameExists(nameTextBox.Text))
            {
                MessageBox.Show(nameTextBox.Text + " Already Exists!");
                return;
            }


            if (_customerManager.AddMethod(nameTextBox.Text,addressTextBox.Text,contactTextBox.Text))
            {
                MessageBox.Show("Saved");
            }
            else
            {
                MessageBox.Show("Not saved");
            }
            showDataGridView.DataSource = _customerManager.ShowMethod();
        }
        private void showButton_Click(object sender, EventArgs e)
        {
            showDataGridView.DataSource = _customerManager.ShowMethod();
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            //Id Must
            if (string.IsNullOrEmpty(idTextBox.Text))
            {
                MessageBox.Show("Id cannot be empty");
                return;
            }


            if (_customerManager.DeleteMethod(Convert.ToInt32(idTextBox.Text)))
            {
                MessageBox.Show("Deleted");
            }
            else
            {
                MessageBox.Show("Not deleted");
            }
            showDataGridView.DataSource = _customerManager.ShowMethod();
        }
        private void updateButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(idTextBox.Text))
            {
                MessageBox.Show("id cannot be empty");
                return;
            }
            if (_customerManager.UpdateMethod(nameTextBox.Text, addressTextBox.Text, contactTextBox.Text, Convert.ToInt32(idTextBox.Text)))
            {
                MessageBox.Show("Updated");
            }
            else
            {
                MessageBox.Show("Not updated");
            }
            showDataGridView.DataSource = _customerManager.ShowMethod();
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            showDataGridView.DataSource = _customerManager.SearchMethod(nameTextBox.Text);
        }



    }
}
