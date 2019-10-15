using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VechicleWindowsFormsApp
{
    public partial class VehicleApp : Form
    {
        Vehicle aVehicle = new Vehicle();
       // List<double> speedList = new List<double> { };

        public VehicleApp()
        {
            InitializeComponent();
        }

        

        private void createButton_Click(object sender, EventArgs e)
        {

            aVehicle = new Vehicle(nameTextBox.Text, regnoTextBox.Text);

            nameTextBox.Clear();
            regnoTextBox.Clear();

            MessageBox.Show("Vehicle " + aVehicle.Name + ", Reg No: " + aVehicle.RegNo + " created");
            createButton.Enabled = false;

        }


        private void enterButton_Click(object sender, EventArgs e)
        {
            //  aVehicle.Speed = Convert.ToDouble(speedTextBox.Text);
            aVehicle.Speed = aVehicle.Addspeed(Convert.ToDouble(speedTextBox.Text));


        }





        private void sButton_Click(object sender, EventArgs e)
        {
            minspeedTextBox.Text = aVehicle.Minspeed().ToString();
            maxspeedTextBox.Text = aVehicle.Maxspeed().ToString();
            averagespeedTextBox.Text = aVehicle.Averagespeed().ToString();
        }
    }
}
