using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace CoffeeShopCRUD.Repositoryitem
{
    public class OrderRepository
    {
        public bool AddMethod(int customer_id, int item_id, int quantity)
        {
            try
            {
                //connection
                string connectionString = @"Server=DESKTOP-CR4IGJV; DataBase=CoffeeShop; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //command
                string commandString = @"INSERT INTO Orders (Customer_ID,Items_ID,Quantity) VALUES (" + customer_id + "," + item_id + "," + quantity + ")";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                //execution

                sqlConnection.Open();

                int isExecuted = sqlCommand.ExecuteNonQuery();

                if (isExecuted > 0)
                {
                    return true;
                    //MessageBox.Show("Saved Successfully");
                }
                //else
                //{
                //    MessageBox.Show("Not Saved");
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
                string commandString = @"SELECT * FROM Orders";
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
                string commandString = @"DELETE FROM Orders WHERE Order_ID  = " + id + "";
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



        public bool UpdateMethod(int customer_id, int item_id, int quantity, int order_id)
        {
            try
            {
                //connection
                string connectionString = @"Server=DESKTOP-CR4IGJV; DataBase=CoffeeShop; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //command
                string commandString = @"UPDATE Orders SET Customer_ID = " + customer_id + ", Items_id=" + item_id + ", Quantity=" + quantity + " WHERE Order_ID = " + order_id + "";
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
                string commandString = @"SELECT Orders.Order_ID, Customer.Name,Items.Items_Name,Orders.Quantity FROM Orders  JOIN Customer ON Orders.Customer_ID=Customer.Customer_ID JOIN Items ON Orders.Items_ID=Items.Items_ID WHERE Customer.Name='" + name + "';";
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
