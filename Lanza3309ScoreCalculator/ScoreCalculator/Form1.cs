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


namespace ScoreCalculator
{
    public partial class frmScoreCalc : Form
    {
        //declare two class variables
        private decimal scoretotal;
        private int scorecount;
        //create list mydata
        private static List<int> myData = new List<int>();

        public frmScoreCalc()
        {
            InitializeComponent();
            
        }
        //escape key closes form
        private void frmScoreCalc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
           
            
        }

       

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //take in score from text
            int score = int.Parse(txtScore.Text);
            //add to list
            myData.Add(score);

            //add to overall scoretotal
            scoretotal = scoretotal + score;
           //add to overall score average
            decimal scoreAverage = scoretotal / myData.Count;

            //Display
            txtScoreTotal.Text = scoretotal.ToString();
            txtScoreCount.Text = myData.Count.ToString();
            txtAverage.Text = scoreAverage.ToString();
            //bring focus back to txtScore
            txtScore.Focus();

        }

        private void btnClearScores_Click(object sender, EventArgs e)
        {
            scoretotal = 0;
            txtScore.Text = "";
            txtScoreTotal.Text = "";
            txtAverage.Text = "";
            myData = new List<int>();

            txtScore.Focus();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            //Display
            String displayNumbersInList = "";
            //sort numbers in the list
            myData.Sort();
            int count = 0;
            bool isEmpty = !myData.Any();

            //if list is empty
            if (isEmpty)
            {
                MessageBox.Show("Enter values before clicking display button.");
            }

            foreach (int i in myData)
            {
                displayNumbersInList += i.ToString() + "\n";
                count++;
                //make sure over 20 numbers are not in list
                if (myData.Count() >= 20)
                {
                    MessageBox.Show("Max scores of 20");
                    break;
                }
                //display list
                else if (count == myData.Count)
                {
                    MessageBox.Show(displayNumbersInList, "number of scores entered: " + myData.Count);
                    break;
                        
                }
            }
            txtScore.Focus();
        }
    }
}
