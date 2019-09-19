using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studentinformationapp
{
    public partial class studentform : Form
    {
        List<string> id = new List<string> { };
        List<string> name = new List<string> { };
        List<string> mobile = new List<string> { };
        List<int>age= new List<int> { };
        List<string> address = new List<string> { };
        List<double> gpa = new List<double> { };
        int identify = 0;
        public studentform()
        {
            InitializeComponent();
        }
        
        private void addButton_Click(object sender, EventArgs e)
        {
            AddStudentInfo();
        }

        private void AddStudentInfo()
        {
            try
            {
                if (idTextBox.Text == "" || nameTextBox.Text == "" || mobileTextBox.Text == "" || ageTextBox.Text == "" || addresstextBox.Text == "" || gpaTextBox.Text == "" )
                {
                    if (idTextBox.Text == "" || idTextBox.Text.Length < 4)
                    {
                        idTextBox.Text = string.Empty;
                        MessageBox.Show("id Required or too short");
                    }
                    if (nameTextBox.Text == "" || nameTextBox.Text.Length>30)
                    {
                        nameTextBox.Text = string.Empty;
                        MessageBox.Show("name Required or too long");
                    }
                    else if (mobileTextBox.Text == "" || mobileTextBox.Text.Length !=11)
                    {
                        mobileTextBox.Text = string.Empty;
                        MessageBox.Show("mobile number Required or must be 11 character");
                    }
                    else if (ageTextBox.Text == "")
                    {
                        ageTextBox.Text = string.Empty;
                        MessageBox.Show("age required");
                    }
                    else if (addresstextBox.Text == "")
                    {
                        addresstextBox.Text = string.Empty;
                        MessageBox.Show("address Required");
                    }
                    else if (gpaTextBox.Text == ""|| (Convert.ToDouble(gpaTextBox.Text)<0 && Convert.ToDouble(gpaTextBox.Text)>4))
                    {
                        gpaTextBox.Text = string.Empty;
                        MessageBox.Show("gpa required or not in range");
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    //id.Add(idTextBox.Text);
                    //idTextBox.Clear();
                    if (id.Contains(idTextBox.Text)==true)
                    {
                        MessageBox.Show("This id have already used!");
                        return;
                    }
                    else
                    {
                        id.Add(idTextBox.Text);
                        idTextBox.Clear();

                    }

                    name.Add(nameTextBox.Text);
                    nameTextBox.Clear();

                    //mobile.Add(mobileTextBox.Text);
                    //mobileTextBox.Clear();
                    if (mobile.Contains(mobileTextBox.Text) == true)
                    {
                        MessageBox.Show("This mobile number have already used!");
                        return;
                    }
                    else
                    {
                        mobile.Add(mobileTextBox.Text);
                        mobileTextBox.Clear();

                    }
                    name.Add(nameTextBox.Text);
                    nameTextBox.Clear();
                    
                    age.Add(Convert.ToInt32(ageTextBox.Text));
                    ageTextBox.Clear();

                    address.Add(addresstextBox.Text);
                    addresstextBox.Clear();

                    gpa.Add(Convert.ToDouble(gpaTextBox.Text));
                    gpaTextBox.Clear();
                    identify++;
                    ShowSingleStudentInfo();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wrong Input");
                return;
            }
        }
        private void ShowSingleStudentInfo()
        {
            try
            {
                string message = "";
                for (int i = 0; i < id.Count(); i++)
                {
                    if (i == identify - 1)
                    {
                        message += "serial: " + identify + "\n" +"ID: " +id[i] +"\n" + "Name: " + name[i] + "\n" + "Mobile: " + mobile[i] + "\n" + "Age: " + age[i] + "\n" + "Address: " + address[i] + "\n" + "GPA: " + gpa[i] + "\n";
                    }
                }
                resultRichTextBox.Text = message;
            }
            catch (Exception)
            {
                MessageBox.Show("Single Show Wrong");
            }
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            ShowAllStudentsInfo();
            ShowMaxGpa();
            ShowMinGpa();
            ShowAvgGpa();
            ShowTotalGpa();

        }

        private void ShowAllStudentsInfo()
        {
            try
            {
                string message = "";
                for (int i = 0; i < id.Count(); i++)
                {
                    message += "ID: " + id[i] + "\n" + "Name: " + name[i] + "\n" + "Mobile No: " + mobile[i] + "\n" + "Age: " + age[i] + "\n" + "Address: " + address[i] + "\n" + "GPA: " + gpa[i] + "\n";

                }
                resultRichTextBox.Text = message;
            }
            catch (Exception)
            {
                MessageBox.Show("All Show Wrong");
            }
        }
        private void ShowMaxGpa()
        {
            double max_gpa;
            
            max_gpa = gpa.Max();
            
            maxTextBox.Text = max_gpa.ToString();
            string maxname = "";
            for (int i =0; i<gpa.Count();i++)
            {
                if(gpa[i] == max_gpa)
                {
                    maxname += name[i];
                }
            }
            maxnameTextBox.Text = maxname;

        }
        private void ShowMinGpa()
        {
            double min_gpa;

            min_gpa = gpa.Min();

            minTextBox.Text = min_gpa.ToString();
            string minname = "";
            for (int i = 0; i < gpa.Count(); i++)
            {
                if (gpa[i] == min_gpa)
                {
                    minname += name[i];
                }
            }
            minnameTextBox.Text = minname;
        }
        private void ShowAvgGpa()
        {
            double avg_gpa;

            avg_gpa = gpa.Average();

            avgTextBox.Text = avg_gpa.ToString();
        }
        private void ShowTotalGpa()
        {
            double total_gpa;

            total_gpa = gpa.Sum();

            totalTextBox.Text = total_gpa.ToString();


        }
    }

}

