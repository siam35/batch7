using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RefrigeratorWindowsFormsApp
{
    public partial class Refrigerator : Form
    {
        Refrigeratorweight aRefrigeratorweight = new Refrigeratorweight();
        public Refrigerator()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            double maximumWeightItCanTake = Convert.ToDouble(maxweightTextBox.Text);

            aRefrigeratorweight.MaximumWeightItCanTake = maximumWeightItCanTake;
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            try
            {


                double numberOfItems = Convert.ToDouble(noofitemTextBox.Text);
                double weightPerUnit = Convert.ToDouble(weightTextBox.Text);

                double getCurrentWeight = aRefrigeratorweight.GetCurrentWeight(numberOfItems, weightPerUnit);
                double getRemainingWeight = aRefrigeratorweight.GetRemainingWeight();

                currentweightTextBox.Text = getCurrentWeight.ToString();
                remainingweightTextBox.Text = getRemainingWeight.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
