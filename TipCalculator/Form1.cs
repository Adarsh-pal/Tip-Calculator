using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TipCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 
        // Method to be called when leave event fires on Bill input
        // 

        private void Bill_Input_Leave(object sender, EventArgs e)
        {
            ValidateBillAmount();
        }

        // 
        // Method to be called when leave event fires on tip input
        // 

        private void Tip_Input_Leave(object sender, EventArgs e)
        {

            if (Tip_Input.Text == "")
            {

                Error2.SetError(TipError, "Tip % can't be empty");
                TipError.Text = "Tip % can't be empty";

            }
            else
            {
                Error2.SetError(TipError, "");
                TipError.Text = "";

            }



        }

        // 
        // Method to be called when leave event fires on people count input
        // 

        private void PeopleCount_Input_Leave(object sender, EventArgs e)
        {
            if (PeopleCount_Input.Text == "")
            {

                Error3.SetError(PeopleCountError, "People count can't be empty");
                PeopleCountError.Text = "People count can't be empty";

            }
            else
            {
                Error3.SetError(PeopleCountError, "");
                PeopleCountError.Text = "";

            }


        }

        // 
        // Method to be called when key down event fires on tip input
        // 

        private void Tip_Input_KeyDown(object sender, KeyEventArgs e)
        {
            textReset();
        }

        // 
        // Method to be called when key down event fires on people count input
        // 

        private void PeopleCount_Input_KeyDown(object sender, KeyEventArgs e)
        {
            textReset();
        }

        // 
        // Method to be called when text change event fires on bill input
        // 

        private void Bill_Input_TextChanged(object sender, EventArgs e)
        {
            textReset();
            ValidateBillAmount();
        }

        // 
        // Method to be called when click event fires on calculate button
        // 

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            if (BillError.Text == "" && TipError.Text == "" && PeopleCountError.Text == "")
            {
                double billAmount = double.Parse(Bill_Input.Text);

                double tipPercent = (double)Tip_Input.Value;

                int personCount = (int)PeopleCount_Input.Value;

                double totalTip = CalculateTip(billAmount, tipPercent);

                double tipPerPerson = totalTip / personCount;
                Tip_Output.Text = "$" + tipPerPerson;

                double total = billAmount + totalTip;

                double totalPerPerson = total / personCount;
                Total_Output.Text = "$" + totalPerPerson;

            }
            else
            {

                Tip_Output.Text = "$";
                Total_Output.Text = "$";

            }
        }

        // 
        // Method to reset tip output and total output
        // 

        private void textReset()
        {
            Tip_Output.Text = "$";
            Total_Output.Text = "$";
        }

        // 
        // Method to validate bill amount
        // 

        private void ValidateBillAmount()
        {

            string amount = this.Bill_Input.Text;
            double value;
            if (amount == "")
            {
                Error1.SetError(BillError, "Bill can't be Empty");
                BillError.Text = "Bill can't be Empty";
            }
            else if (double.TryParse(amount, out value))
            {
                if (value < 0)
                {

                    Error1.SetError(BillError, "Bill can't be less than $0 ");
                    BillError.Text = "Bill can't be less than $0 ";

                }
                else
                {

                    Error1.SetError(BillError, "");
                    BillError.Text = "";

                }
            }
            else
            {

                Error1.SetError(BillError, "Invalid input, please enter a number");
                BillError.Text = "Invalid input, please enter a number";

            }


        }

        // 
        // Method to calculate tip
        // 

        private double CalculateTip(double billAmount, double tipPercent)
        {

            double tip = (tipPercent * billAmount)/100;

            return tip;

        }

    }
}
