using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorldC_
{
    public partial class WLCal : Form
    {
        public WLCal()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            TextBoxLength.Text = "";
            TextBoxWidth.Text  = "";
            TextBoxResult.Text = "";
            TextBoxLength.Focus();
        }

        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            int VLength, VWidth, VResult;
            VLength = Convert.ToInt32(TextBoxLength.Text);
            VWidth  = Convert.ToInt32(TextBoxWidth.Text);

            VResult = VLength * VWidth;
            TextBoxResult.Text = VResult.ToString();
        }
    }
}
