using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Test2WindowsFormsApp.Model;
namespace Test2WindowsFormsApp.Repository
{
    public class CustomerRepository
    {

        public bool Add(Customer customer)

        {
            bool isAdded = false;
            try
            {
                //Connection
                string connectionString = @"Server=DESKTOP-CR4IGJV; Database=AccountDB; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command 

                string commandString = @"INSERT INTO Customer(Name,Email,AccountNo,Date) VALUES ('" + customer.Name + "','" + customer.Email + "'," +
                    "" + customer.AccountNo + ",'" + customer.Date + "')";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
                //Open
                sqlConnection.Open();
                //Insert
                int isExecuted = sqlCommand.ExecuteNonQuery();
                if (isExecuted > 0)
                {
                    isAdded = true;
                }

                //if (!isNameExists(nameTextBox.Text))
                //{
                //    //Insert
                //    int isExecuted = sqlCommand.ExecuteNonQuery();
                //    if (isExecuted > 0)
                //    {
                //        isAdded = true;
                //    }

                //}
                //else
                //{
                //    MessageBox.Show(nameTextBox.Text + "Already Exists!");
                //}


                //Close
                sqlConnection.Close();


            }
            catch (Exception exeption)
            {
                //MessageBox.Show(exeption.Message);
            }

            return isAdded;
        }

        public bool IsAccountExists(Customer customer)
        {
            bool exists = false;
            try
            {
                //Connection
                string connectionString = @"Server=DESKTOP-CR4IGJV; Database=AccountDB; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command 
                //INSERT INTO Items (Name, Price) Values ('Black', 120)
                string commandString = @"SELECT * FROM Customer WHERE Code='" + customer.AccountNo + "'";
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
                //MessageBox.Show(exeption.Message);
            }

            return exists;
        }
    }
}
