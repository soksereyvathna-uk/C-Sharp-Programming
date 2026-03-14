using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iphone_Calculator
{
    
    public partial class Form1 : Form
        
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnAC_Click(object sender, EventArgs e)
        {
            TxtResult.Text = "";
     
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            TxtResult.Text = TxtResult.Text +"7";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            TxtResult.Text = TxtResult.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            TxtResult.Text = TxtResult.Text +"9";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            TxtResult.Text = TxtResult.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            TxtResult.Text = TxtResult.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            TxtResult.Text = TxtResult.Text + "6";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            TxtResult.Text = TxtResult.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            TxtResult.Text = TxtResult.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            TxtResult.Text = TxtResult.Text + "3";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            TxtResult.Text = TxtResult.Text + "0";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            
        }
    }
}
