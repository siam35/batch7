using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApptestcoffee
{
    public partial class Coffee : Form
    {
        public Coffee()
        {
            InitializeComponent();
        }
        
        private void saveButton_Click(object sender, EventArgs e)
        {
           
            if (orderComboBox.Text == "")
            {
                MessageBox.Show("please enter your choice");
            }
            else
            {
                
                int price=0;
                if (orderComboBox.Text == "Black")
                {
                    price = price + 120;
                }
                if (orderComboBox.Text == "Cold")
                {
                    price = price + 100;
                }
                if (orderComboBox.Text == "Hot")
                {
                    price = price + 90;
                }
                if (orderComboBox.Text == "Regular")
                {
                    price = price + 80;
                }
                int total_price = price * Convert.ToInt32(quantityTextBox.Text);

                string name = nameTextBox.Text;
                string contact = contactTextBox.Text;
                string address = addressTextBox.Text;
                string order = orderComboBox.Text;
                string quantity = quantityTextBox.Text;
                string tprice = total_price.ToString();

                infoRichTextBox.AppendText("Name:        " + name + "\n");
                infoRichTextBox.AppendText("Contact:     " + contact + "\n");
                infoRichTextBox.AppendText("Address:     " + address + "\n");
                infoRichTextBox.AppendText("Order:       " + order + "\n");
                infoRichTextBox.AppendText("Quantity:    " + quantity + "\n");
                infoRichTextBox.AppendText("Price:       " + tprice + "\n");

            }
            }

        
    }
}
