﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Assignment9WindowsFormsApp.Model;

namespace Assignment9WindowsFormsApp.Repository
{
    public class CustomerRepository
    {
        public bool Add(Customer customer)
        {
            bool isAdded = false;
            try
            {
                //Connection
                string connectionString = @"Server=DESKTOP-CR4IGJV; Database=CustomersDB; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command 
                
                string commandString = @"INSERT INTO Customer(Code,Name,Address,Contact,District_Id) VALUES ('"+customer.Code+"','"+customer.Name+"','"+customer.Address+"','"+customer.Contact+"',"+customer.District_Id+")";
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

       

        public bool IsContactExists(Customer customer)
        {
            bool exists = false;
            try
            {
                //Connection
                string connectionString = @"Server=DESKTOP-CR4IGJV; Database=CustomersDB; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command 
                //INSERT INTO Items (Name, Price) Values ('Black', 120)
                string commandString = @"SELECT * FROM Customer WHERE Contact='" + customer.Contact + "'";
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

        public bool IsCodeExists(Customer customer)
        {
            bool exists = false;
            try
            {
                //Connection
                string connectionString = @"Server=DESKTOP-CR4IGJV; Database=CustomersDB; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command 
                //INSERT INTO Items (Name, Price) Values ('Black', 120)
                string commandString = @"SELECT * FROM Customer WHERE Code='" + customer.Code + "'";
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

        public DataTable Display()
        {

            //Connection
            string connectionString = @"Server=DESKTOP-CR4IGJV; Database=CustomersDB; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //Command 
           
            string commandString = @"SELECT * FROM CustomerDetailsView";
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

        public bool Update(Customer customer)
        {
            try
            {
                //Connection
                string connectionString = @"Server=DESKTOP-CR4IGJV; Database=CustomersDB; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command 
                //UPDATE Items SET Name =  'Hot' , Price = 130 WHERE ID = 1
                string commandString = @"UPDATE Customer SET Code ='"+customer.Code+"', Name = '"+customer.Name+"',Address='"+customer.Address+"', Contact = '"+customer.Contact+"', District_Id = "+customer.District_Id+" WHERE Id = "+customer.Id+"";
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

        public DataTable DistrictCombo()
        {

            //Connection
            string connectionString = @"Server=DESKTOP-CR4IGJV; Database=CustomersDB; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //Command 
            //INSERT INTO Items (Name, Price) Values ('Black', 120)
            string commandString = @"SELECT Id, Name FROM District";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            //Open
            sqlConnection.Open();

            //Show
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);


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
            return dataTable;

        }

        public DataTable Search(Customer customer)
        {

            //Connection
            string connectionString = @"Server=DESKTOP-CR4IGJV; Database=CustomersDB; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //Command 

            string commandString = @"SELECT * FROM CustomerDetailsView WHERE Code="+customer.Code+"";
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
            //    //Customer customer = new Customer();
            //    //District district = new District();
            //    customer.Id = Convert.ToInt32(sqlDataReader["Id"]);
            //    customer.Code = sqlDataReader["Code"].ToString();
            //    customer.Name = sqlDataReader["Name"].ToString();
            //    customer.Address = sqlDataReader["Address"].ToString();
            //    customer.Contact = sqlDataReader["Contact"].ToString();
            //    customer.District_Id = Convert.ToInt32(sqlDataReader["District_Id"]);
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
            return dataTable;
            

        }
    }

       
    }
