using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test2WindowsFormsApp
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomerUi customerUi = new CustomerUi();
            customerUi.Tag = this;
            customerUi.Show(this);
         //   Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TransactionUi transaction = new TransactionUi();
            transaction.Tag = this;
            transaction.Show(this);
           // Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SearchUi search = new SearchUi();
            search.Tag = this;
            search.Show(this);
          //  Hide();
        }
    }
}
