using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Real_Calculate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int width, length, result;
            width  = Convert.ToInt32(TxtWidth.Text);
            length = Convert.ToInt32(TxtLength.Text);
            result = width * length;
            TxtResult.Text= result.ToString();
            //result = Convert.ToInt32(TxtResult.Text);

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            TxtLength.Text = string.Empty;
            TxtWidth.Text = string.Empty;
            TxtResult.Text = string.Empty;
            TxtLength.Focus();
           

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
