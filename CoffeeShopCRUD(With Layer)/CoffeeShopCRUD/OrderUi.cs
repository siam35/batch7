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
    public partial class OrderUi : Form
    {
        OrderManager _orderManager = new OrderManager();
        public OrderUi()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (_orderManager.AddMethod(Convert.ToInt32(customeridTextBox.Text), Convert.ToInt32(itemidTextBox.Text), Convert.ToInt32(quantityTextBox.Text)))
            {
                MessageBox.Show("Saved");

            }
            else
            {
                MessageBox.Show("Not saved");
            }
            showDataGridView.DataSource = _orderManager.ShowMethod();
        }
        private void showButton_Click(object sender, EventArgs e)
        {
            showDataGridView.DataSource = _orderManager.ShowMethod();
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(orderidTextBox.Text))
            {
                MessageBox.Show("order id cannot be empty");
                return;
            }
            if (_orderManager.DeleteMethod(Convert.ToInt32(orderidTextBox.Text)))
            {
                MessageBox.Show("Deleted");
            }
            else
            {
                MessageBox.Show("Not Deleted");
            }
            showDataGridView.DataSource = _orderManager.ShowMethod();
        }
        private void updateButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(orderidTextBox.Text))
            {
                MessageBox.Show("order id cannot be empty");
                return;
            }
            if (_orderManager.UpdateMethod(Convert.ToInt32(customeridTextBox.Text), Convert.ToInt32(itemidTextBox.Text), Convert.ToInt32(quantityTextBox.Text), Convert.ToInt32(orderidTextBox.Text)))
            {
                MessageBox.Show("Updated");
            }
            else
            {
                MessageBox.Show("Not Updated");
            }
            showDataGridView.DataSource = _orderManager.ShowMethod();
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            showDataGridView.DataSource = _orderManager.SearchMethod(customernameTextBox.Text);
        }

       


    }
}
