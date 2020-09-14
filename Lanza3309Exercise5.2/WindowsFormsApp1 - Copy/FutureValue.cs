//Dominic Lanza
//Professor Friedman
//CIS 3309
//09/07/2020
//This program calculates the future value of a monthly investment through the duration of many years while
//taking a yearly interest rate.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            //enable clear form button when loaded
            clearForm();
        }

      

        private void clearForm() {
            //disable labels, text boxes, and calculate button
            label1.Enabled = false;
            label2.Enabled = false;
            label3.Enabled = false;
            label4.Enabled = false;
            txtMonthlyInvestment.Enabled = false;
            txtInterestRate.Enabled = false;
            txtFutureValue.Enabled = false;
            txtYears.Enabled = false;
            btnCalculate.Enabled = false;

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //formula to calculate
            decimal monthlyInvestment = Convert.ToDecimal(txtMonthlyInvestment.Text);
            decimal yearlyInterestRate = Convert.ToDecimal(txtInterestRate.Text);
            int years = Convert.ToInt32(txtYears.Text);

            int months = years * 12;
            decimal monthlyInterestRate = yearlyInterestRate / 12 / 100;

            decimal futureValue = 0m;
            //loop to calculate the future value of a monthly invest
            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + monthlyInvestment)
                    * (1 + monthlyInterestRate);
            }

            txtFutureValue.Text = futureValue.ToString("c");
            //reset focus to txt Monthly Investment
            txtMonthlyInvestment.Focus();
            //message box for user direction
            MessageBox.Show("If you want another calculation press Enter Data Button.",
                "Re-Run!");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEnterData_Click(object sender, EventArgs e)
        {
            //Enable text boxes and labels
            txtMonthlyInvestment.Enabled = true;
            txtMonthlyInvestment.Text = "";
            txtInterestRate.Enabled = true;
            txtInterestRate.Text = "";
            txtFutureValue.Enabled = true;
            txtFutureValue.Text = "";
            txtYears.Enabled = true;
            txtYears.Text = "";
            label1.Enabled = true;
            label2.Enabled = true;
            label3.Enabled = true;
            label4.Enabled = true;
            btnCalculate.Enabled = false;
        }

        private void txtYears_TextChanged(object sender, EventArgs e)
        {
            //finally enable calculate button
            btnCalculate.Enabled = true;
        }
    }
}
