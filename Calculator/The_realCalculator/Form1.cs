using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_realCalculator
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void TxtResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            TxtResult.Text = TxtResult.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            TxtResult.Text = TxtResult.Text + "2";
        }
    }
}
