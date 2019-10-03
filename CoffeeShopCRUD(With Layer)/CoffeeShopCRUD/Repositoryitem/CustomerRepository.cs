using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using CoffeeShopCRUD.Model;

namespace CoffeeShopCRUD.Repositoryitem
{
    public class CustomerRepository
    {
        public bool AddMethod(Customer customer)
        {
            try
            {
                //connection
                string connectionString = @"Server=DESKTOP-CR4IGJV; DataBase=CoffeeShop; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //command
                string commandString = @"INSERT INTO Customer(Name,Address,Contact) VALUES ('" + customer.Name + "','" + customer.address + "','" + customer.contact + "')";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                //execution

                sqlConnection.Open();

                int isExecuted = sqlCommand.ExecuteNonQuery();

                if (isExecuted > 0)
                {
                    return true;
                    // MessageBox.Show("Saved Successfully");
                }
                //else
                //{
                //    MessageBox.Show("Not Saved");
                //}

                sqlConnection.Close();

            }
            catch (Exception exception)
            {
                //MessageBox.Show("Invalid input or this Name is already used");
            }
            return false;
        }

        public bool IsNameExists(Customer customer)
        {
            bool exists = false;
            try
            {
                //Connection
                string connectionString = @"Server=DESKTOP-CR4IGJV; Database=CoffeeShop; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command 
                //INSERT INTO Items (Name, Price) Values ('Black', 120)
                string commandString = @"SELECT * FROM Customer WHERE Name='" + customer.Name + "'";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                //Open
                sqlConnection.Open();
                //Show
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    exists = true;
                }
                //Close
                sqlConnection.Close();

            }
            catch (Exception exeption)
            {
                //   MessageBox.Show(exeption.Message);
            }

            return exists;
        }




        public DataTable ShowMethod()
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
            //if (dataTable.Rows.Count > 0)
            //{
            //    showDataGridView.DataSource = dataTable;
            //}
            //else
            //{
            //    showDataGridView.DataSource = null;
            //    MessageBox.Show("No data found");
            //}



            sqlConnection.Close();

            return dataTable;

        }



        public bool DeleteMethod(Customer customer)
        {
            try
            {
                //connection
                string connectionString = @"Server=DESKTOP-CR4IGJV; DataBase=CoffeeShop; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //command
                string commandString = @"DELETE FROM Customer WHERE Id = " + customer.Id + "";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                //execution

                sqlConnection.Open();

                int isExecuted = sqlCommand.ExecuteNonQuery();

                if (isExecuted > 0)
                {
                    return true;
                    //MessageBox.Show("Deleted Successfully");
                }
                //else
                //{
                //    MessageBox.Show("Not Deleted");
                //}


                sqlConnection.Close();
            }
            catch (Exception exception)
            {
                //   MessageBox.Show(exception.Message);
            }
            return false;
        }



        public bool UpdateMethod(Customer customer)
        {
            try
            {
                //connection
                string connectionString = @"Server=DESKTOP-CR4IGJV; DataBase=CoffeeShop; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //command
                string commandString = @"UPDATE Customer SET Name = '" + customer.Name + "', Address = '" + customer.address + "', Contact='" + customer.contact + "' WHERE Id = " + customer.Id + "";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                //execution

                sqlConnection.Open();


                int isExecuted = sqlCommand.ExecuteNonQuery();

                if (isExecuted > 0)
                {
                    return true;
                    //MessageBox.Show("Updated Successfully");
                }
                //else
                //{
                //    MessageBox.Show("Not Updated");
                //}

                sqlConnection.Close();
            }
            catch (Exception exception)
            {
                // MessageBox.Show(exception.Message);
            }
            return false;
        }



        public DataTable SearchMethod(Customer customer)
        {

            //connection
            string connectionString = @"Server=DESKTOP-CR4IGJV; DataBase=CoffeeShop; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //command
            string commandString = @"SELECT * FROM Customer WHERE Name='" + customer.Name + "'";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            //execution

            sqlConnection.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            //if (dataTable.Rows.Count > 0)
            //{
            //    showDataGridView.DataSource = dataTable;
            //}
            //else
            //{
            //    showDataGridView.DataSource = null;
            //    MessageBox.Show("No data found");
            //}



            sqlConnection.Close();
            return dataTable;
        }

        public DataTable CustomerCombo()
        {
            //connection
            string connectionString = @"Server=DESKTOP-CR4IGJV; DataBase=CoffeeShop; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //command
            string commandString = @"SELECT Id,Name FROM Customer";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            //execution

            sqlConnection.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            //if (dataTable.Rows.Count > 0)
            //{
            //    showDataGridView.DataSource = dataTable;
            //}
            //else
            //{
            //    showDataGridView.DataSource = null;
            //    MessageBox.Show("No data found");
            //}



            sqlConnection.Close();

            return dataTable;

        }
    }
}
