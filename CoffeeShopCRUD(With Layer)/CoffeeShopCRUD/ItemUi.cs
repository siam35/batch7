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
    public partial class ItemUi : Form
    {
        ItemManager _itemManager = new ItemManager();
        public ItemUi()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //Name unique check
            if (_itemManager.IsNameExists(nameTextBox.Text))
            {
                MessageBox.Show(nameTextBox.Text + " Already Exists!");
                return;
            }

            //Set Price as Mandatory
            if (String.IsNullOrEmpty(priceTextBox.Text))
            {
                MessageBox.Show("Price Can not be Empty!!!");
                return;
            }
            bool isadded =_itemManager.AddMethod(nameTextBox.Text,Convert.ToDouble (priceTextBox.Text));

            if (isadded)
            {
                MessageBox.Show("Saved");
            }
            else
            {
                MessageBox.Show("not saved");
            }
            showDataGridView.DataSource = _itemManager.ShowMethod();
        }
        private void showButton_Click(object sender, EventArgs e)
        {
            showDataGridView.DataSource = _itemManager.ShowMethod();
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            //Set Id as Mandatory
            if (String.IsNullOrEmpty(idTextBox.Text))
            {
                MessageBox.Show("Id Can not be Empty!!!");
                return;
            }

            //Delete
            if (_itemManager.DeleteMethod(Convert.ToInt32(idTextBox.Text)))
            {
                MessageBox.Show("Deleted");
            }
            else
            {
                MessageBox.Show("Not Deleted");
            }

            showDataGridView.DataSource = _itemManager.ShowMethod();
        }
        private void updateButton_Click(object sender, EventArgs e)
        {
            //Set Id as Mandatory
            if (String.IsNullOrEmpty(idTextBox.Text))
            {
                MessageBox.Show("Id Can not be Empty!!!");
                return;
            }
            //Set Price as Mandatory
            if (String.IsNullOrEmpty(priceTextBox.Text))
            {
                MessageBox.Show("Price Can not be Empty!!!");
                return;
            }

            if (_itemManager.UpdateMethod(nameTextBox.Text, Convert.ToDouble(priceTextBox.Text), Convert.ToInt32(idTextBox.Text)))
            {
                MessageBox.Show("Updated");
                
            }
            else
            {
                MessageBox.Show("Not Updated");
            }
            showDataGridView.DataSource = _itemManager.ShowMethod();

        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            
            showDataGridView.DataSource = _itemManager.SearchMethod(nameTextBox.Text);
        }

  
    }
}
