using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InterestCalculator
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void tbox_pricipal_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void tbox_time_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbox_rate_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            double pricipal= Convert.ToDouble(tbox_pricipal.Text);
            double time = Convert.ToDouble(tbox_time.Text);
            double rate = Convert.ToDouble(tbox_rate.Text);

            CalculateInterest interest = new CalculateInterest(pricipal, time, rate);
            
            double result = interest.getInterest();

            lbl_result.Text = "Interest is: " + result.ToString();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            tbox_pricipal.Text = "";
            tbox_time.Text = "";
            tbox_rate.Text = "";

            lbl_result.Text = "";
        }

        private void btn_quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
