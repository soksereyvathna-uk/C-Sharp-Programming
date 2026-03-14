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
    public partial class FormListBox : Form
    {
        public FormListBox()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            TextBoxAdd.Focus(); 
            ListBox.Items.Add(TextBoxAdd.Text);
            TextBoxAdd.Clear();
            TextBoxAdd.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ListBox.Items.Count.ToString());
        }

        private void FormListBox_Load(object sender, EventArgs e)
        {
           TextBoxAdd.Focus();
        }

        private void ButtonSort_Click(object sender, EventArgs e)
        {
            ListBox.Sorted = true;
        }

        private void ButtonRemove_Click(object sender, EventArgs e)
        {
            ListBox.Items.Remove(ListBox.SelectedItem);// remove by list box
            ListBox.Items.Remove(TextBoxAdd.Text);// remove by textbox
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            ListBox.Items.Clear();

        }
    }
}
