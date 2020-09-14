using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculateLetterGrade
{
    public partial class frmCalculateGrade : Form
    {
        public frmCalculateGrade()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            txtName.Focus();

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //         Check contents of name
            //           if blank name
            //             display popup "Name cannot Be Blank. Enter"
            //        and then reset focus on txtName
            //       if  textbook have < 0 characters enable

            if (String.IsNullOrEmpty(txtName.Text))
            {
                System.Windows.Forms.MessageBox.Show("Name Cannot Be Blank. Reenter");
            }
            else {
                txtNumberGrade.Enabled = true;
                txtLetterGrade.Enabled = true;
                btnCalculate.Enabled = true;
    //            label4.Enabled = true;
     //           Button2_Click.Enabled = true;
                label2.Enabled = true;
                label3.Enabled = true;
                label1.Enabled = true;


            }
        }

        private void txtNumberGrade_TextChanged(object sender, EventArgs e)
        {
            txtNumberGrade.Focus();
        }

        private void txtLetterGrade_TextChanged(object sender, EventArgs e)
        {
            txtLetterGrade.Text = letterGrade;
            
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal score = Convert.ToDecimal(txtNumberGrade.Text);
            string letterGrade = "";
            if (score >= 90)
            {
                letterGrade = "A";
            }
            else if (score >= 80)
            {
                letterGrade = "B";
            }
            else if (score >= 70)
            {
                letterGrade = "C";
            }
            else if (score >= 60)
            {
                letterGrade = "D";
            }
            else if (score >= 0)
            {
                letterGrade = "F";
            }
            else {
                letterGrade = "Z";
            }

        }
    }
}
