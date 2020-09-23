using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Dominic Lanza
//Professor Friedman
//CIS 3309
//09/23/2020



namespace DateHandling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculateDueDays_Click(object sender, System.EventArgs e)
        {
            // TODO: Add code to calculate the days until due date
            try
            {
                DateTime futureDate;
                DateTime.TryParse(txtFutureDate.Text, out futureDate);

                DateTime currentDate = DateTime.Today;

                TimeSpan timeTillDue = futureDate.Subtract(currentDate);
                int daysTillDue = timeTillDue.Days;

                MessageBox.Show("Current date: " + "\t" + Convert.ToString(currentDate.ToShortDateString()) + "\n\n" +
                                "Future date: " + "\t" + Convert.ToString(futureDate.ToShortDateString()) + "\n\n" +
                                "Days until due: " + "\t" + Convert.ToString(daysTillDue), "Due Days Calculation");
            }
            catch
            {
                MessageBox.Show("Unable to understand date, please ReEnter.");
            }

            }

        private void btnCalculateAge_Click(object sender, System.EventArgs e)
        {
            // TODO: Add code to calculate the age
            try
            {
                DateTime currentDate = DateTime.Today;
                DateTime birthDate = DateTime.Parse(txtBirthDate.Text);
                TimeSpan ageSpan = currentDate.Subtract(birthDate);
                int age = ageSpan.Days / 365;
                String output = "Current Date:      " + currentDate.ToString("dddd, dd MMMM, yyyy") + "\n" + "Birth Date:        " + birthDate.ToString("dddd, dd MMMM, yyyy") + "\n" + "Age:                  " + age;
                MessageBox.Show(output);
            }
            catch
            {
                MessageBox.Show("Unable to understand date, please ReEnter.");
            }


        }

        private void btnExit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}