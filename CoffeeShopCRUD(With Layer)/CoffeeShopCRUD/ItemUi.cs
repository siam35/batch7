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
    public partial class ItemUi : Form
    {
        ItemManager _itemManager = new ItemManager();
        public ItemUi()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Item item = new Item();
            item.Name = nameTextBox.Text;

            //Name unique check
            if (_itemManager.IsNameExists(item))
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
            item.Price = Convert.ToDouble(priceTextBox.Text);
            bool isadded =_itemManager.AddMethod(item);

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
            Item item = new Item();
            //Set Id as Mandatory
            if (String.IsNullOrEmpty(idTextBox.Text))
            {
                MessageBox.Show("Id Can not be Empty!!!");
                return;
            }
            item.Id =Convert.ToInt32(idTextBox.Text);
            //Delete
            if (_itemManager.DeleteMethod(item))
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
            Item item = new Item();
            //Set Id as Mandatory
            if (String.IsNullOrEmpty(idTextBox.Text))
            {
                MessageBox.Show("Id Can not be Empty!!!");
                return;
            }
            item.Id = Convert.ToInt32(idTextBox.Text);
            //Set Price as Mandatory
            if (String.IsNullOrEmpty(priceTextBox.Text))
            {
                MessageBox.Show("Price Can not be Empty!!!");
                return;
            }
            item.Price = Convert.ToDouble(priceTextBox.Text);

            if (String.IsNullOrEmpty(nameTextBox.Text))
            {
                MessageBox.Show("Name Can not be Empty!!!");
                return;
            }
            item.Name = nameTextBox.Text;

            if (_itemManager.UpdateMethod(item))
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
            Item item = new Item();
            item.Name = nameTextBox.Text;
            showDataGridView.DataSource = _itemManager.SearchMethod(item);
        }

        private void showDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (showDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                showDataGridView.CurrentRow.Selected = true;
                idTextBox.Text = showDataGridView.Rows[e.RowIndex].Cells["Id"].FormattedValue.ToString();
                nameTextBox.Text = showDataGridView.Rows[e.RowIndex].Cells["Name"].FormattedValue.ToString();
                priceTextBox.Text = showDataGridView.Rows[e.RowIndex].Cells["Price"].FormattedValue.ToString();
                

            }
        }
    }
}
