using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University_Budgeter_1
{
    public partial class Form1 : Form
    {
        //value for yearloan
        private float yearLoan=0;
        //value for the month's loan money
        private float monthLoan=0;
        private float rent=0;
        private float subs=0;
        private float food=0;
        private float wage=0;


        //shows current gross income
        public float showCurrent() => (monthLoan + wage) - rent - subs;
        //shows net savings to work with
        public float showNet(float grossIncome) => grossIncome - food;


        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void yearLoanAmount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                yearLoan = float.Parse(yearLoanAmount.Text);
            }
            catch (Exception)
            { yearLoan = 0; }
            monthLoan = (yearLoan / 12);
            grossResult.Text = showCurrent().ToString("0.00");
            netResult.Text = showNet(float.Parse(grossResult.Text)).ToString("0.00");
        }

        private void monthlyWageAmount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                wage = float.Parse(monthlyWageAmount.Text);
            }
            catch (Exception)
            { wage = 0; }
            grossResult.Text = showCurrent().ToString("0.00");
            netResult.Text = showNet(float.Parse(grossResult.Text)).ToString("0.00");
        }

        private void rentAmount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                rent = float.Parse(rentAmount.Text);
            }
            catch (Exception)
            { rent = 0; }
            grossResult.Text = showCurrent().ToString("0.00");
            netResult.Text = showNet(float.Parse(grossResult.Text)).ToString("0.00");

        }

        private void subscriptionAmount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                subs = float.Parse(subscriptionAmount.Text);
            }
            catch (Exception)
            { subs = 0; }
            grossResult.Text = showCurrent().ToString("0.00");
            netResult.Text = showNet(float.Parse(grossResult.Text)).ToString("0.00");
        }

        private void foodCostAmount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                food = float.Parse(foodCostAmount.Text);
            }
            catch (Exception)
            { food = 0; }
            netResult.Text = showNet(float.Parse(grossResult.Text)).ToString("0.00");

        }
    }
}
