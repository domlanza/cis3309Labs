//Dominic Lanza
//Professor Frank Friedman
//CIS 3309
//Exercise 6.2 
//Form to calculate tax owed on amount of income 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.AcceptButton = btnCalculate; //Enables Enter key to calculate
            //Enables ESC to close Form
            this.KeyPreview = true;
            this.KeyPress += (ss, ee) =>
            {
                if (ee.KeyChar == 27) //= KeyChar 27 is the esc key
                {
                    Environment.Exit(1);
                }

            };
            }
    

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //If txtName is empty then user cannot pass and give pop up.
            if (String.IsNullOrEmpty(txtName.Text))
            {
                System.Windows.Forms.MessageBox.Show("Name Cannot Be Blank. Reenter");
            }
            else
            {
                textBox2.Enabled = true;
                textBox1.Enabled = true;
                btnCalculate.Enabled = true;
                label2.Enabled = true;
                label3.Enabled = true;
                label1.Enabled = true;


            }
        }

        //Checks for valid input of taxable income
        private void taxIncomeValidation(decimal input)
        {
            //if input is not a positive value
            if (input < 0)
            {
                MessageBox.Show("Please enter a positive value");
            }
        }
            
            
            
         

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //turn input into a decimal
            decimal taxableIncome = decimal.Parse(textBox1.Text);
            //call the validation method to check input is not negative
            taxIncomeValidation(taxableIncome);
            //Method to do calculation
            decimal tax = taxTableLookup(taxableIncome);
            //Display in textbox
            textBox2.Text = tax.ToString();


        }



        //Given an income, calclates tax for that income
        private decimal taxTableLookup(decimal taxableIncome) {

            decimal taxOwed = 0m;

            if (taxableIncome > 0 && taxableIncome < 9225)
            {
                taxOwed = taxableIncome * 0.1m;
            }

            else if (taxableIncome > 9225 && taxableIncome <= 37450)
            {
                taxOwed = 922.50m + ((taxableIncome - 9225) * 0.15m);
            }

            else if (taxableIncome > 37450 && taxableIncome <= 90750)
            {
                taxOwed = 5156.25m + ((taxableIncome - 37450) * 0.25m);
            }

            else if (taxableIncome > 90750 && taxableIncome <= 189300)
            {
                taxOwed = 18481.25m + ((taxableIncome - 90750) * 0.28m);
            }

            else if (taxableIncome > 189300 && taxableIncome <= 411500)
            {
                taxOwed = 46075.25m + ((taxableIncome - 189300) * 0.33m);
            }

            else if (taxableIncome > 411500 && taxableIncome <= 413200)
            {
                taxOwed = 119401.25m + ((taxableIncome - 411500) * 0.35m);
            }

            else if (taxableIncome > 413200)
            {
                taxOwed = 119996.25m + ((taxableIncome - 413200) * 0.396m);
            }
            return taxOwed;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
