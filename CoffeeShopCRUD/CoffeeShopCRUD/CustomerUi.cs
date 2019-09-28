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

namespace CoffeeShopCRUD
{
    public partial class CustomerUi : Form
    {
        public CustomerUi()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddMethod();
        }

        private void AddMethod()
        {
            try
            {
                //connection
                string connectionString = @"Server=DESKTOP-CR4IGJV; DataBase=CoffeeShop; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //command
                string commandString = @"INSERT INTO Customer(Name,Address,Contact) VALUES ('" + nameTextBox.Text + "','" + addressTextBox.Text + "','" + contactTextBox.Text + "')";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                //execution

                sqlConnection.Open();

                int isExecuted = sqlCommand.ExecuteNonQuery();

                if (isExecuted > 0)
                {
                    MessageBox.Show("Saved Successfully");
                }
                else
                {
                    MessageBox.Show("Not Saved");
                }

                sqlConnection.Close();

            }
            catch(Exception exception)
            {
                MessageBox.Show("Invalid input or this Name is already used");
            }
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            ShowMethod();
        }

        private void ShowMethod()
        {
            try
            {
                //connection
                string connectionString = @"Server=DESKTOP-CR4IGJV; DataBase=CoffeeShop; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //command
                string commandString = @"SELECT * FROM Customer";
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
            }
            catch (Exception exception)

            {

                MessageBox.Show(exception.Message);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DeleteMethod();
        }

        private void DeleteMethod()
        {
            try
            {
                //connection
                string connectionString = @"Server=DESKTOP-CR4IGJV; DataBase=CoffeeShop; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //command
                string commandString = @"DELETE FROM Customer WHERE Customer_ID = " + idTextBox.Text + "";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                //execution

                sqlConnection.Open();

                int isExecuted = sqlCommand.ExecuteNonQuery();

                if (isExecuted > 0)
                {
                    MessageBox.Show("Deleted Successfully");
                }
                else
                {
                    MessageBox.Show("Not Deleted");
                }


                sqlConnection.Close();
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            UpdateMethod();
        }

        private void UpdateMethod()
        {
            try
            {
                //connection
                string connectionString = @"Server=DESKTOP-CR4IGJV; DataBase=CoffeeShop; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //command
                string commandString = @"UPDATE Customer SET Name = '" + nameTextBox.Text + "', Address = '" + addressTextBox.Text + "', Contact='" + contactTextBox.Text + "' WHERE Customer_ID = " + idTextBox.Text + "";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                //execution

                sqlConnection.Open();


                int isExecuted = sqlCommand.ExecuteNonQuery();

                if (isExecuted > 0)
                {
                    MessageBox.Show("Updated Successfully");
                }
                else
                {
                    MessageBox.Show("Not Updated");
                }

                sqlConnection.Close();
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {

            SearchMethod();
        }

        private void SearchMethod()
        {
            try
            {
                //connection
                string connectionString = @"Server=DESKTOP-CR4IGJV; DataBase=CoffeeShop; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //command
                string commandString = @"SELECT * FROM Customer WHERE Name='" + nameTextBox.Text + "'";
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
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);

            }
        }
    }
}
