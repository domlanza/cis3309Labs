using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceTotal
{
    public partial class frmInvoiceTotal : Form
    {
        //Step for initalize controls
        int numberofInvoices = 0;
        decimal totalOfInvoices = 0m;
        decimal invoiceaverage = 0m;
        decimal smallestInvoice = 99999999999;
        decimal largestInvoice = 0;



        public frmInvoiceTotal()
        {

            InitializeComponent();
            //Step for initalize controls



        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

        

            //try catch statement to check decimals

            try
            {
                decimal subtotal = Convert.ToDecimal(txtEnterSubtotal.Text);
                decimal discountPercent = .25m;
                decimal discountAmount = Math.Round(subtotal * discountPercent, 2);
                decimal invoiceTotal = subtotal - discountAmount;

                txtSubtotal.Text = subtotal.ToString("c");
                numberofInvoices += 1;
                totalOfInvoices = totalOfInvoices + invoiceTotal;
                invoiceaverage = totalOfInvoices / numberofInvoices;

                if (invoiceTotal < smallestInvoice)
                {
                    smallestInvoice = invoiceTotal;
                }

                if (invoiceTotal > largestInvoice)
                {
                    largestInvoice = invoiceTotal;
                }

                txtNumberOfInvoices.Text = numberofInvoices.ToString();
                txtTotalOfInvoices.Text = totalOfInvoices.ToString("c");
                txtInvoiceAverage.Text = invoiceaverage.ToString("c");
                txtEnterSubtotal.Text = "";

                txtSmallestInvoice.Text = smallestInvoice.ToString();
                txtLargestInvoice.Text = largestInvoice.ToString();


                txtDiscountPercent.Text = discountPercent.ToString("p1");
                txtDiscountAmount.Text = discountAmount.ToString("c");
                txtTotal.Text = invoiceTotal.ToString("c");

                txtEnterSubtotal.Focus();
            }


            catch
            {
                MessageBox.Show("Please enter a valid decimal for the Subtotal field");

            }

          
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtDiscountAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clear values
            numberofInvoices = 0;
            totalOfInvoices = 0m;
            invoiceaverage = 0m;

            smallestInvoice = 99999999;
            largestInvoice = 0;

            //Clear textboxs
            txtNumberOfInvoices.Text = "";
            txtTotalOfInvoices.Text = "";
            txtInvoiceAverage.Text = "";
            txtSubtotal.Clear();
            txtDiscountPercent.Clear();
            txtDiscountAmount.Clear();
            txtTotal.Clear();
            txtSmallestInvoice.Clear();
            txtLargestInvoice.Clear();

            //Reset Focus
            txtEnterSubtotal.Focus();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void frmInvoiceTotal_Load(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            txtName.Focus();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtName.Text))
            {
                System.Windows.Forms.MessageBox.Show("Name Cannot Be Blank. Reenter");
            }
            else
            {
                label8.Enabled = true;
                txtEnterSubtotal.Enabled = true;
                btnCalculate.Enabled = true;
                btnClear.Enabled = true;
                btnExit.Enabled = true;

            }
        }

        private void txtEnterSubtotal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
    