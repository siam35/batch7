using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopCRUD.Repositoryitem
{
    public class CustomerRepository
    {
        public bool AddMethod(string name, string address, string contact)
        {
            try
            {
                //connection
                string connectionString = @"Server=DESKTOP-CR4IGJV; DataBase=CoffeeShop; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //command
                string commandString = @"INSERT INTO Customer(Name,Address,Contact) VALUES ('" + name + "','" + address + "','" + contact + "')";
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

        public bool IsNameExists(string name)
        {
            bool exists = false;
            try
            {
                //Connection
                string connectionString = @"Server=DESKTOP-CR4IGJV; Database=CoffeeShop; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command 
                //INSERT INTO Items (Name, Price) Values ('Black', 120)
                string commandString = @"SELECT * FROM Customer WHERE Name='" + name + "'";
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



        public bool DeleteMethod(int id)
        {
            try
            {
                //connection
                string connectionString = @"Server=DESKTOP-CR4IGJV; DataBase=CoffeeShop; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //command
                string commandString = @"DELETE FROM Customer WHERE Customer_ID = " + id + "";
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



        public bool UpdateMethod(string name, string address, string contact, int id)
        {
            try
            {
                //connection
                string connectionString = @"Server=DESKTOP-CR4IGJV; DataBase=CoffeeShop; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //command
                string commandString = @"UPDATE Customer SET Name = '" + name + "', Address = '" + address + "', Contact='" + contact + "' WHERE Customer_ID = " + id + "";
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



        public DataTable SearchMethod(string name)
        {

            //connection
            string connectionString = @"Server=DESKTOP-CR4IGJV; DataBase=CoffeeShop; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //command
            string commandString = @"SELECT * FROM Customer WHERE Name='" + name + "'";
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
