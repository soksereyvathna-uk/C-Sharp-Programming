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
    public partial class InformalCal : Form
    {
        int First2, Second2, Result2,  First4, Second4, Result4;
        float First3, Second3, Result1, Result3, First1, Second1;
        private void ButtonMulty_Click(object sender, EventArgs e)
        {
            First4 = Convert.ToInt32(TextBoxFirst.Text);
            Second4= Convert.ToInt32(TextBoxSecond.Text);
            Result4 = First4 * Second4;
            TextBoxResult.Text = Result4.ToString();
        }

        private void ButtonDivide_Click(object sender, EventArgs e)
        {
            First3 = Convert.ToSingle(TextBoxFirst.Text);
            Second3 = Convert.ToSingle(TextBoxSecond.Text);
            Result3 = First3 / Second3;
            TextBoxResult.Text = Result3.ToString();
        }

        public InformalCal()
        {
            InitializeComponent();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            
            First1 = Convert.ToSingle(TextBoxFirst.Text);
            Second1 = Convert.ToSingle(TextBoxSecond.Text);
            Result1 = First1 + Second1;
            TextBoxResult.Text = Result1.ToString();
        }

        private void ButtonMinus_Click(object sender, EventArgs e)
        {
            First2 = Convert.ToInt32(TextBoxFirst.Text);
            Second2 = Convert.ToInt32(TextBoxSecond.Text);
            Result2 = First2 - Second2;
            TextBoxResult.Text = Result2.ToString();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            TextBoxFirst.Text  = "";
            TextBoxSecond.Text = "";
            TextBoxResult.Text = "";
            TextBoxFirst.Focus();
        }
    }
}
