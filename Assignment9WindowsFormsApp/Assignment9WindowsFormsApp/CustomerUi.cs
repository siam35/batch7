using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assignment9WindowsFormsApp.Model;
using Assignment9WindowsFormsApp.BLL;
using System.Data.SqlClient;

namespace Assignment9WindowsFormsApp
{
    public partial class CustomerUi : Form
    {
        int value;
        Customer customer = new Customer();
        CustomerManager _customerManager = new CustomerManager();
        public CustomerUi()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();

            if(saveButton.Text == "Update")
            {
                customer.Id = value;
                customer.Code = codeTextBox.Text;
                customer.Name = nameTextBox.Text;
                customer.Address = addressTextBox.Text;
                customer.Contact = contactTextBox.Text;
                customer.District_Id =Convert.ToInt32(districtComboBox.SelectedValue);
                if (_customerManager.Update(customer))
                {
                    MessageBox.Show("Data Updated");
                    saveButton.Text = "Save";
                }
                else
                {
                    MessageBox.Show("Update Error");
                }

                showDataGridView.DataSource = _customerManager.Display();
            }
            else if(saveButton.Text=="Save")
            {
                //Set Code as Mandatory
                if (String.IsNullOrEmpty(codeTextBox.Text) || codeTextBox.Text.Length != 4)
                {
                    MessageBox.Show("Code should be consists of 4 character");
                    return;
                }

                customer.Code = codeTextBox.Text;



                //Check UNIQUE Code
                if (_customerManager.IsCodeExists(customer))
                {
                    MessageBox.Show(codeTextBox.Text + " Already Exists!");
                    return;
                }

                //set name ase mandatory
                if (String.IsNullOrEmpty(nameTextBox.Text))
                {
                    MessageBox.Show("Code should be consists of 4 character");
                    return;
                }


                customer.Name = nameTextBox.Text;
                customer.Address = addressTextBox.Text;

                if (String.IsNullOrEmpty(contactTextBox.Text) || contactTextBox.Text.Length != 11)
                {
                    MessageBox.Show("Contact should be consists of 11 character");
                    return;
                }


                customer.Contact = contactTextBox.Text;

                if (_customerManager.IsContactExists(customer))
                {
                    MessageBox.Show(contactTextBox.Text + " Already Exists!");
                    return;
                }

                customer.District_Id = Convert.ToInt32(districtComboBox.SelectedValue);
                if (_customerManager.Add(customer))
                {
                    MessageBox.Show("Data is saved");
                }
                else
                {
                    MessageBox.Show("Error!!!!!!!");
                }


                showDataGridView.DataSource = _customerManager.Display();
            }

            
        }

        private void CustomerUi_Load(object sender, EventArgs e)
        {
            districtComboBox.DataSource = _customerManager.DistrictCombo();
        }

        private void showDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (showDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {

                showDataGridView.CurrentRow.Selected = true;
                value =Convert.ToInt32(showDataGridView.Rows[e.RowIndex].Cells["Id"].FormattedValue.ToString());
                codeTextBox.Text = showDataGridView.Rows[e.RowIndex].Cells["Code"].FormattedValue.ToString();
                nameTextBox.Text = showDataGridView.Rows[e.RowIndex].Cells["Name"].FormattedValue.ToString();
                addressTextBox.Text = showDataGridView.Rows[e.RowIndex].Cells["Address"].FormattedValue.ToString();
                contactTextBox.Text = showDataGridView.Rows[e.RowIndex].Cells["Contact"].FormattedValue.ToString();
                districtComboBox.Text = showDataGridView.Rows[e.RowIndex].Cells["District_Name"].FormattedValue.ToString();

                saveButton.Text = "Update";
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(codeTextBox.Text))
            {
                MessageBox.Show("Please Enter the code to search");
            }

            customer.Code = codeTextBox.Text;
            showDataGridView.DataSource = _customerManager.Search(customer);

        }

       
    }
    }

