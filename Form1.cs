using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FutureValue19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal monthlyInvestment = Convert.ToDecimal(txtMonthlyInvestment.Text);
            decimal yearlyInterestRate = Convert.ToDecimal(txtInterestRate.Text);
            int years = Convert.ToInt32(txtYears.Text);

            int months = years * 12;
            decimal monthlyInterestRate = yearlyInterestRate / 12 / 100;


            decimal futureValue = CalculateFutureValue(invest: monthlyInvestment, interest: monthlyInterestRate, mn: months);

            txtFutureValue.Text = futureValue.ToString("c");
            txtMonthlyInvestment.Focus();
        }

        private decimal CalculateFutureValue(decimal invest, decimal interest=.05m, int mn=12)
        {
            decimal futureValue = 0m;
            for (int i = 1; i <= mn; i++)
            {
                futureValue = (futureValue + invest) * (1 + interest);
            }
            return futureValue;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearFutureValue(object sender, EventArgs e)
        {
            txtFutureValue.Text = "";
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            txtFutureValue.Text = "";
            txtInterestRate.Text = "";
            txtMonthlyInvestment.Text = "";
            txtYears.Text = "";
        }

        private void btnYear_Click(object sender, EventArgs e)
        {
            frmYear fy = new frmYear();
            fy.ShowDialog();

            if (fy.DialogResult == DialogResult.OK)
            {
                txtYears.Text = fy.Tag.ToString();
                MessageBox.Show(string.Format("You inputted year: {0}", fy.Tag.ToString()), "Year");
            }
            else
            {
                MessageBox.Show("Please enter a valid value", "Error!!");
            }
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            frmInput fi = new frmInput();
            fi.ShowDialog();

            if (fi.DialogResult == DialogResult.OK)
            {
                txtMonthlyInvestment.Text = fi.Tag.ToString();
                MessageBox.Show(string.Format("You inputted: {0}", fi.Tag.ToString()), "Monthly Investment");
            }
            else
            {
                MessageBox.Show("Please enter a valid value", "Error!!");
            }
        }

        private void btnInputRate_Click(object sender, EventArgs e)
        {
            frmInputRate fir = new frmInputRate();
            fir.ShowDialog();

            if (fir.DialogResult == DialogResult.OK)
            {
                txtInterestRate.Text = fir.Tag.ToString();
                MessageBox.Show(string.Format("You inputted rate: {0}", fir.Tag.ToString()), "Interest Rate");
            }
            else
            {
                MessageBox.Show("Please enter a valid value", "Error!!");
            }
        }
    }
}
