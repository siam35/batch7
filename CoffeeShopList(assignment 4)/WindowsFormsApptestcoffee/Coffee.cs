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
        
        int price1;

        string Name, Address, Order, Contact;

       

        int Quantity, price;

        List<string> name = new List<string> { };
        List<string> contact = new List<string> { };
        List<string> address = new List<string> { };
        List<string> order = new List<string> { };
        List<int> quantity = new List<int> { };
        List<int> prices = new List<int> { };

        public Coffee()
        {
            InitializeComponent();
        }

        private void addinfoButton_Click(object sender, EventArgs e)
        {
            if (contactTextBox.Text == "" || nameTextBox.Text == "" || addressTextBox.Text == "" || orderComboBox.Text == "" || quantityTextBox.Text == "")
            {
                MessageBox.Show("All of the fields are required");
            }
            else
            {
                Name = nameTextBox.Text;
                Contact = contactTextBox.Text;
                Address = addressTextBox.Text;
                Order = orderComboBox.Text;
                Quantity = Convert.ToInt32(quantityTextBox.Text);

                string message = "Name: " + Name + "\n" + "contact_no: " + Contact + "\n" + "address: " + Address +"\n"+"order: " + Order + "\n" + "qunatity: " + Quantity + "\n";
                if (orderComboBox.Text == "Black")
                {
                    price1 = Convert.ToInt32(quantityTextBox.Text) * 120;
                    infoRichTextBox.Text = message + " " + "price: " + price1 + "\n";
                }
                if (orderComboBox.Text == "Cold")
                {
                    price1 = Convert.ToInt32(quantityTextBox.Text) * 100;

                    infoRichTextBox.Text = message + " " + "price: " + price1 + "\n";
                }
                if (orderComboBox.Text == "Hot")
                {
                    price1 = Convert.ToInt32(quantityTextBox.Text) * 90;

                    infoRichTextBox.Text = message + " " + "price: " + price1 + "\n";
                }
                if (orderComboBox.Text == "Reguler")
                {
                    price1 = Convert.ToInt32(quantityTextBox.Text) * 80;

                    infoRichTextBox.Text = message + " " + "price: " + price1 + "\n";
                }






            }
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            

           


            name.Add(nameTextBox.Text);
            if (contact.Contains(contactTextBox.Text) == false)
            {
                contact.Add(contactTextBox.Text);
            }
            else
            {
                MessageBox.Show("This number is already given");
            }
            address.Add(addressTextBox.Text);
            order.Add(orderComboBox.Text);
            quantity.Add(Convert.ToInt32 (quantityTextBox.Text));
            //prices.Add(price1);
            string showmessage = "";
            for (int i =0; i <name.Count() ; i++)
            {
                if (order[i] == "Black")
                {
                    price1 = Convert.ToInt32(quantity[i]) * 120;

                }
                if (order[i] == "Cold")
                {
                    price1 = Convert.ToInt32(quantity[i]) * 100;


                }
                if (order[i] == "Hot")
                {
                    price1 = Convert.ToInt32(quantity[i]) * 90;


                }
                if (order[i] == "Reguler")
                {
                    price1 = Convert.ToInt32(quantity[i]) * 80;


                }


                //showmessage += "test: " + name[i];
                showmessage +="name: " +name[i]+"\n" +"contact: "+ contact[i] + "\n" + "address: " +address[i] + "\n" + "order: "+ order[i] + "\n" + "qunatity: " +quantity[i]+"\n"+"price: "+price1+"\n";
                
            }

            
            infoRichTextBox.Text = showmessage;
            
        }


    }
    }
