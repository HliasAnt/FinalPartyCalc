using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalPartyCalc
{
    public partial class Form1 : Form
    {
        
        Dinner dinner;
        BirthDay birthDay;
        public Form1()
        {
            InitializeComponent();

           
            dinner = new Dinner((int)numericUpDown1.Value, FancycheckBox.Checked, HealthycheckBox.Checked); 
            birthDay = new BirthDay((int)numericUpDown2.Value, FancyBirthDayCheckBox.Checked, CakeWritingTextBox.Text);
            DisplayTotalCost();
            DisplayBirthDayCost();

        }

        //Dinner Party 
        private void numericUpDown1_ValueChanged(object sender, EventArgs e) //Change the cost every time we change the numberofpeople
        {
            dinner.NumberOfPeople = (int)numericUpDown1.Value;
            DisplayTotalCost();
        }

        private void FancycheckBox_CheckedChanged(object sender, EventArgs e) // change the Cost every time we change the Fancy checkbox
        {
            dinner.FancyDecorations = FancycheckBox.Checked;
            DisplayTotalCost();
        }

        private void HealthycheckBox_CheckedChanged(object sender, EventArgs e) //change the Cost every time we change the healthy checkbox
        {
            dinner.HealthyDrinks = HealthycheckBox.Checked;
            DisplayTotalCost();
        }

        private void DisplayTotalCost() // display the total in the TextBox
        {
            dinner.NumberOfPeople = (int)numericUpDown1.Value;
            CostTextBox.Text = dinner.TotalCost().ToString("c");
        }
    

        private void CostTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        //BirthDay Party
        private void numericUpDown2_ValueChanged(object sender, EventArgs e) //change the cost every time we change the numberofpeople
        {
            birthDay.NumberOfPeople = (int)numericUpDown2.Value;
            DisplayBirthDayCost();
        }

        private void FancyBirthDayCheckBox_CheckedChanged(object sender, EventArgs e) //change the cost when we choose fancy or not
        {
            birthDay.FancyDecorations = FancyBirthDayCheckBox.Checked;
            DisplayBirthDayCost();
        }

        private void CakeWritingTextBox_TextChanged(object sender, EventArgs e) // change the cost every time we type on the textbox
        {
            birthDay.CakeWriting = CakeWritingTextBox.Text;
            
            DisplayBirthDayCost();
        }
        private void DisplayBirthDayCost() // set the totalCost at the textbox
        {
            TooLongLabel.Visible = birthDay.CakeWritingTooLong();
            birthDay.NumberOfPeople = (int)numericUpDown2.Value;
            BirthDayTotalCostTextBox.Text = birthDay.TotalCost().ToString("c");
        }
    }
}
