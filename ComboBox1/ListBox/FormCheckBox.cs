using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox
{
    public partial class FormCheckBox : Form
    {
        public FormCheckBox()
        {
            InitializeComponent();
        }
        string Value1 = "", Value2 = "", Value3 = "", Value4 = "";

        private void CBNokia_CheckedChanged(object sender, EventArgs e)
        {
            if(CBNokia.Checked == true)
            {
                Value3 = CBNokia.Text;
            }
            else
            {
                Value3 = "";
            }
        }

        private void CBOppo_CheckedChanged(object sender, EventArgs e)
        {
            if (CBOppo.Checked == true)
            {
                Value4 = CBOppo.Text; 
            }
            else
            {
                Value4 = "";
            }
        }

        private void BtnMybutton_Click(object sender, EventArgs e)
        {

        }

        private void CBEnable_CheckedChanged(object sender, EventArgs e)
        {
            
            BtnMybutton.Enabled = CBEnable.Checked;
        }

        private void FormCheckBox_Load(object sender, EventArgs e)
        {

        }

        private void CBIphone_CheckedChanged(object sender, EventArgs e)
        {
            if(CBIphone.Checked == true)
            {
                Value2 = CBIphone.Text;
            }
            else
            {
                Value2 = "";
            }
        }

        private void CBSamSung_CheckedChanged(object sender, EventArgs e)
        {
            if(CBSamSung.Checked == true)
            {
                Value1 = CBSamSung.Text;
            }
            else
            {
                Value1 = "";
            }
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Here is selected: " + Value1 + " " + Value2 + " " + Value3 + " " + Value4);
        }
    }
}
