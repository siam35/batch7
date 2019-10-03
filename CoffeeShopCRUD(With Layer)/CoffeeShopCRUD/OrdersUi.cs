using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoffeeShopCRUD.BLLitem;
using CoffeeShopCRUD.Model;
namespace CoffeeShopCRUD
{
    public partial class OrdersUi : Form
    {
        ItemManager _itemManager = new ItemManager();
        CustomerManager _customerManager = new CustomerManager();
        public OrdersUi()
        {
            InitializeComponent();
        }

      

       
        private void OrdersUi_Load(object sender, EventArgs e)
        {
            itemComboBox.DataSource = _itemManager.ItemCombo();
            customerComboBox.DataSource = _customerManager.CustomerCombo();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Name: "+customerComboBox.Text+" " +"ID: "+customerComboBox.SelectedValue+" "+"name: "+itemComboBox.Text+" "+"ID: "+itemComboBox.SelectedValue+" ");
            AddMethod();
            ShowMethod();
        }



        private void AddMethod()
        {
            
                //bool isAdded = false;
                try
                {

                    //connection
                    string connectionString = @"Server=DESKTOP-CR4IGJV; DataBase=CoffeeShop; Integrated Security=True";
                    SqlConnection sqlConnection = new SqlConnection(connectionString);

                    //command
                    
                    string commandString = @"INSERT INTO Orders (Customer_ID,Items_ID,Quantity,TotalPrice) VALUES ("+customerComboBox.SelectedValue+","+itemComboBox.SelectedValue+","+quantityTextBox.Text+",(SELECT Price FROM Items WHERE Id = "+itemComboBox.SelectedValue+")*"+quantityTextBox.Text+")";
                    SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                    //execution

                    sqlConnection.Open();

                    int isExecuted = sqlCommand.ExecuteNonQuery();

                    if (isExecuted > 0)
                    {
                         MessageBox.Show("Saved Successfully");
                        //isAdded = true;
                    }
                    else
                    {
                        MessageBox.Show("Not Saved");
                    }

                    sqlConnection.Close();

                }
                catch (Exception exception)
                {
                    //MessageBox.Show("Invalid input or this item name is already used");
                }
                //return isAdded;
            }

        public void ShowMethod()
        {

            //connection
            string connectionString = @"Server=DESKTOP-CR4IGJV; DataBase=CoffeeShop; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //command
            string commandString = @"SELECT * FROM Orders";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            //execution

            sqlConnection.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {
                showDataGridView.DataSource = dataTable;
            }
            else
            {
                showDataGridView.DataSource = null;
                MessageBox.Show("No data found");
            }



            sqlConnection.Close();
            //return dataTable;
        }


    }


}

