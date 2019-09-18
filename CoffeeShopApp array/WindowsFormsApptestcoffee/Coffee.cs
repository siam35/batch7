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
        string[] customerArray = new string[20];
        string[] addressArray = new string[20];
        string[] orderArray = new string[20];
        string[] contactArray = new string[20];
        int[] quantityArray = new int[20];
        int[] priceArray = new int[20];


        string Customer, Address, Order;
        int Contact, Quantity, price, index = 0;

        private void addinfoButton_Click(object sender, EventArgs e)
        {
            if (contactTextBox.Text == "" || nameTextBox.Text == "" || addressTextBox.Text == "" || orderComboBox.Text == "" || quantityTextBox.Text == "")
            {
                MessageBox.Show("Enter value please");
            }
            else
            {

                Customer = nameTextBox.Text;
                Contact = Convert.ToInt32(contactTextBox.Text);
                Address = addressTextBox.Text;
                Order = orderComboBox.Text;
                Quantity = Convert.ToInt32(quantityTextBox.Text);
                string Result = Order + Quantity;
                string message = " Customar Name: " + Customer + " \n Contact No: " + Contact + "\n Address: " + Address +
                        "\n\n Order: " + Order + "\n Quantity: " + Quantity;

                if (orderComboBox.Text == "Black")
                {
                    price = Convert.ToInt32(quantityTextBox.Text) * 120;
                    MessageBox.Show(message);
                    infoRichTextBox.Text = "Custmar Purchase Information:\n\n" + message + "\n________________________\n Total Price is: " + price;
                }
                if (orderComboBox.Text == "Cold")
                {
                    price = Convert.ToInt32(quantityTextBox.Text) * 100;
                    MessageBox.Show(message);
                    infoRichTextBox.Text = "Custmar Purchase Information:\n\n" + message + "\n________________________\n Total Price is: " + price;

                }
                if (orderComboBox.Text == "Hot")
                {
                    price = Convert.ToInt32(quantityTextBox.Text) * 90;
                    MessageBox.Show(message);
                    infoRichTextBox.Text = "Custmar Purchase Information:\n\n" + message + "\n________________________\n Total Price is: " + price;

                }
                if (orderComboBox.Text == "Regular")
                {
                    price = Convert.ToInt32(quantityTextBox.Text) * 80;
                    MessageBox.Show(message);
                    infoRichTextBox.Text = "Custmar Purchase Information:\n\n" + message + "\n________________________\n Total Price is: " + price;

                }
                customerArray[index] = nameTextBox.Text;
                contactArray[index] = contactTextBox.Text;
                bool isExist = Array.Exists(contactArray, element => element == "contact number to check");
                if (isExist == true)
                {
                    contactArray[index] = contactTextBox.Text;
                }
                else
                {
                   
                    MessageBox.Show("phone number already exist");
                }
                addressArray[index] = addressTextBox.Text;
                orderArray[index] = orderComboBox.Text;
                quantityArray[index] = Convert.ToInt32(quantityTextBox.Text);
                priceArray[index] = price;
                
                index++;



            }
        }

        public Coffee()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {


            string Show_Result = "";
            //int Size = Convert.ToInt32(sizeTextBox.Text);
            for (index = 0; index < 20; index++)
            
            {
                Show_Result += " \n\n\n" + " Customar Name: " + customerArray[index] + " \n Contact No: " + contactArray[index]
                    + "\n Address: " + addressArray[index] + "\n\n Order: " + orderArray[index] + "\n Quantity: " +
                    quantityArray[index] + "\n________________________\n Total Price is: " + priceArray[index];
            }
            infoRichTextBox.Text = Show_Result;



        }
        }
    }
