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
    public class AccountRepository
    {

        public bool AddAmount(Account account)

        {
            bool isAdded = false;
            try
            {
                //Connection
                string connectionString = @"Server=DESKTOP-CR4IGJV; Database=AccountDB; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command 

                string commandString = @"INSERT INTO Account(AccountNo,Amount) VALUES (" + account.AccountNo+ "," + account.Amount + ")";
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

        public bool Update(Account account)
        {


            try
            {
                //Connection
                string connectionString = @"Server=DESKTOP-CR4IGJV; Database=AccountDB; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command 
                //UPDATE Items SET Name =  'Hot' , Price = 130 WHERE ID = 1
                string commandString = @"UPDATE Account SET Amount = Amount + "+account.input+" WHERE AccountNo = "+account.AccountNo+"";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                //Open
                sqlConnection.Open();

                //Insert
                int isExecuted = sqlCommand.ExecuteNonQuery();
                if (isExecuted > 0)
                {
                    return true;
                }
                //Close
                sqlConnection.Close();


            }
            catch (Exception exeption)
            {
                //MessageBox.Show(exeption.Message);
            }
            return false;
        }

        public bool WithUpdate(Account account)
        {
            try
            {
                //Connection
                string connectionString = @"Server=DESKTOP-CR4IGJV; Database=AccountDB; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command 
                //UPDATE Items SET Name =  'Hot' , Price = 130 WHERE ID = 1
                string commandString = @"UPDATE Account SET Amount = Amount - " + account.input + " WHERE AccountNo = " + account.AccountNo + "";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                //Open
                sqlConnection.Open();

                //Insert
                int isExecuted = sqlCommand.ExecuteNonQuery();
                if (isExecuted > 0)
                {
                    return true;
                }
                //Close
                sqlConnection.Close();


            }
            catch (Exception exeption)
            {
                //MessageBox.Show(exeption.Message);
            }
            return false;
        }

    }
}
