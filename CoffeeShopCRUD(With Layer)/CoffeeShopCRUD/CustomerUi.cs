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
using CoffeeShopCRUD.Model;

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
            Customer customer = new Customer();
            customer.Name = nameTextBox.Text;
            //Name unique check
            if (_customerManager.IsNameExists(customer))
            {
                MessageBox.Show(nameTextBox.Text + " Already Exists!");
                return;
            }
            customer.address = addressTextBox.Text;
            customer.contact = contactTextBox.Text;

            if (_customerManager.AddMethod(customer))
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
            Customer customer = new Customer();
            
            //Id Must
            if (string.IsNullOrEmpty(idTextBox.Text))
            {
                MessageBox.Show("Id cannot be empty");
                return;
            }
            customer.Id =Convert.ToInt32(idTextBox.Text);

            if (_customerManager.DeleteMethod(customer))
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
            Customer customer = new Customer();
            if (string.IsNullOrEmpty(idTextBox.Text))
            {
                MessageBox.Show("id cannot be empty");
                return;
            }
            customer.Id =Convert.ToInt32(idTextBox.Text);
            if (string.IsNullOrEmpty(nameTextBox.Text))
            {
                MessageBox.Show("Name cannot be empty");
                return;
            }
            customer.Name = nameTextBox.Text;
            if (string.IsNullOrEmpty(addressTextBox.Text))
            {
                MessageBox.Show("Address cannot be empty");
                return;
            }
            customer.address = addressTextBox.Text;

            if (string.IsNullOrEmpty(contactTextBox.Text))
            {
                MessageBox.Show("Contact cannot be empty");
                return;
            }
            customer.contact = contactTextBox.Text;

            if (_customerManager.UpdateMethod(customer))
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
            Customer customer = new Customer();
            showDataGridView.DataSource = _customerManager.SearchMethod(customer);
        }

        private void showDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (showDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                showDataGridView.CurrentRow.Selected = true;
                idTextBox.Text = showDataGridView.Rows[e.RowIndex].Cells["Id"].FormattedValue.ToString();
                nameTextBox.Text = showDataGridView.Rows[e.RowIndex].Cells["Name"].FormattedValue.ToString();
                addressTextBox.Text = showDataGridView.Rows[e.RowIndex].Cells["Address"].FormattedValue.ToString();
                contactTextBox.Text = showDataGridView.Rows[e.RowIndex].Cells["Contact"].FormattedValue.ToString();

            }
        }


    }
}
