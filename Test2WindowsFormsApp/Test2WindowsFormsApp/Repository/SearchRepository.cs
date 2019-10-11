using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test2WindowsFormsApp.Model;
using System.Data;
using System.Data.SqlClient;
namespace Test2WindowsFormsApp.Repository
{
    public class SearchRepository
    {
        public DataTable Search(Customer customer)
        {

            //Connection
            string connectionString = @"Server=DESKTOP-CR4IGJV; Database=AccountDB; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //Command 

            string commandString = @"SELECT Customer.AccountNo,Customer.Name, Customer.Date, Account.Amount FROM Customer LEFT JOIN Account ON Account.AccountNo = Customer.AccountNo WHERE Customer.AccountNo ="+customer.AccountNo+" ";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            //Open
            sqlConnection.Open();

            //Show
            //With DataAdapter
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            //With DataAdapter
            //SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            //List<Customer> customers = new List<Customer>();

            //while (sqlDataReader.Read())
            //{
            //    Customer customer = new Customer();
            //    //District district = new District();
            //    customer.Id = Convert.ToInt32(sqlDataReader["Id"]);
            //    customer.Code = sqlDataReader["Code"].ToString();
            //    customer.Name = sqlDataReader["Name"].ToString();
            //    customer.Address = sqlDataReader["Address"].ToString();
            //    customer.Contact = sqlDataReader["Contact"].ToString();
            //    customer.District_Id =Convert.ToInt32(sqlDataReader["District_Id"]);
            //    // district.Name = sqlDataReader["District_Name"].ToString();

            //    customers.Add(customer);
            //}
            //if (sqlDataReader.NextResult())
            //{
            //    while (sqlDataReader.Read())
            //    {
            //        District district = new District();
            //        district.Name = sqlDataReader["District_Name"].ToString();
            //        //customers.Add(district);       
            //    }
            //}

            //if (dataTable.Rows.Count > 0)
            //{

            //    //showDataGridView.DataSource = dataTable;
            //}
            //else
            //{
            //    //MessageBox.Show("No Data Found");
            //}

            //Close
            sqlConnection.Close();
            //return dataTable;
            return dataTable;

        }
    }
}
