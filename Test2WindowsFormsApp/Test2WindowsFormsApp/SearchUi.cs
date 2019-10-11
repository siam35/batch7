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
    public partial class SearchUi : Form
    {
        SearchManager _searchManager = new SearchManager();
        
        public SearchUi()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            if (String.IsNullOrEmpty(searchTextBox.Text))
            {
                MessageBox.Show("Please Enter the code to search");
            }

            customer.AccountNo =Convert.ToInt32(searchTextBox.Text);
            showDataGridView.DataSource = _searchManager.Search(customer);
        }
    }
}
