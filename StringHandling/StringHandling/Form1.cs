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
//09/21/2020


namespace StringHandling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnParseName_Click(object sender, System.EventArgs e)
        {
            string fullName = txtFullName.Text;
            //helper function to make first letter capital and remainder lowercase
            fullName = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(fullName.ToLower());
            fullName = fullName.Trim();
            //if name has < 2 part or >4 parts
            
            string[] names = fullName.Split(' ');
            if (names.Length >= 4) {
                MessageBox.Show("Name must have two or three parts.");
                txtFullName.Focus();
            }

            else if (names.Length <= 1)
            {
                MessageBox.Show("Name must have two or three parts.");
                txtFullName.Focus();
            }

            else if (names.Length == 2)
            {
                string firstpart = ("First name:      " + names[0] + Environment.NewLine);
                string secondpart = (Environment.NewLine + "Last name:      " + names[1] + Environment.NewLine);
                string full = (firstpart + secondpart);
                MessageBox.Show(full);
            }

            else if (names.Length == 3)
            {
                string firstpart = ("First name:      " + names[0] + Environment.NewLine);
                string secondpart = (Environment.NewLine + "Middle name:      " + names[1] + Environment.NewLine);
                string thirdpart = (Environment.NewLine + "Last name:      " + names[2] + Environment.NewLine);
                string fullfull = (firstpart + secondpart + thirdpart);
                MessageBox.Show(fullfull);
            }
        }



        private void btnEditPhoneNumber_Click(object sender, System.EventArgs e)
        {
            string phonenumber = txtPhoneNumber.Text;
            string checknumber = DigitsOnly(phonenumber);
            //check amount of digits inputed
            if (checknumber.Length != 10)
            {
                MessageBox.Show("You must enter exactly 10 digits");
                txtPhoneNumber.Focus();
            }
            else
            {

                string firstanswer = phonenumber;
                string firstpart = ("Entered:    " + firstanswer + Environment.NewLine);
                string secondanswer = phonenumber;
                string secondanswerfin = DigitsOnly(secondanswer);
                string secondpart = (Environment.NewLine + "Digits only:     " + secondanswerfin + Environment.NewLine);
                string thirdanswer;
                thirdanswer = secondanswerfin.Insert(3, "-");
                string thirdanswer2 = thirdanswer.Insert(7, "-");
                string thirdpart = (Environment.NewLine + "Standard format:     " + thirdanswer2 + Environment.NewLine);
                string final = (firstpart + secondpart + thirdpart);
                MessageBox.Show(final);
            }
        }
        //method to make phone number just digits
        public string DigitsOnly(string s)
        {
            string res = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (Char.IsDigit(s[i]))
                    res += s[i];
            }
            return res;
        }
        //Exit button to close page
        private void btnExit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

    }
}