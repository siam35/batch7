using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopCRUD.Repositoryitem
{
    public class ItemRepository
    {
        public bool AddMethod(string name, double price)
        {
            bool isAdded = false;
            try
            {
                //connection
                string connectionString = @"Server=DESKTOP-CR4IGJV; DataBase=CoffeeShop; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //command
                string commandString = @"INSERT INTO Items (Items_Name, Price) Values ('" + name + "', " + price + ")";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                //execution

                sqlConnection.Open();

                int isExecuted = sqlCommand.ExecuteNonQuery();

                if (isExecuted > 0)
                {
                    // MessageBox.Show("Saved Successfully");
                    isAdded = true;
                }
                //else
                //{
                //    MessageBox.Show("Not Saved");
                //}

                sqlConnection.Close();

            }
            catch (Exception exception)
            {
                //MessageBox.Show("Invalid input or this item name is already used");
            }
            return isAdded;
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
                string commandString = @"SELECT * FROM Items WHERE Items_Name='" + name + "'";
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
               // MessageBox.Show(exeption.Message);
            }

            return exists;
        }

        public bool DeleteMethod(int id)
        {
            try
            {
                //connection
                string connectionString = @"Server=DESKTOP-CR4IGJV; DataBase=CoffeeShop; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //command
                string commandString = @"DELETE FROM Items WHERE Items_ID = " + id + "";
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
                //MessageBox.Show(exception.Message);
            }
            return false;
        }


        public bool UpdateMethod(string name, double price, int id)
        {
            try
            {
                //connection
                string connectionString = @"Server=DESKTOP-CR4IGJV; DataBase=CoffeeShop; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //command
                string commandString = @"UPDATE Items SET Items_Name='" + name + "',Price=" + price + " WHERE Items_ID=" + id + " ";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                //execution

                sqlConnection.Open();

                int isExecuted = sqlCommand.ExecuteNonQuery();

                if (isExecuted > 0)
                {
                    return true;
                    // MessageBox.Show("Updated Successfully");
                }
                //else
                //{
                //    MessageBox.Show("not Updated");
                //}


                sqlConnection.Close();
            }
            catch (Exception exception)
            {
              //  MessageBox.Show(exception.Message);
            }
            return false;
        }

        public DataTable ShowMethod()
        {
           
                //connection
                string connectionString = @"Server=DESKTOP-CR4IGJV; DataBase=CoffeeShop; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //command
                string commandString = @"SELECT * FROM Items";
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

        public DataTable SearchMethod(string name)
        {
           
                //connection
                string connectionString = @"Server=DESKTOP-CR4IGJV; DataBase=CoffeeShop; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //command
                string commandString = @"SELECT * FROM Items WHERE Items_Name='" + name + "'";
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

