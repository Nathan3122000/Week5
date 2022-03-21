using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            listBox.Items.Add(textBox.Text);
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelDisplay.Text = listBox.SelectedItem.ToString();
        }

        private void checkBoxAktif_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxAktif.Checked = true;
        }

        private void checkboxWarnaMerah_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAktif.Checked == true) ;
            labelDisplay.ForeColor = Color.Red;
        }

        private void checkBoxWarnaBiru_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAktif.Checked == true) ;
            labelDisplay.ForeColor = Color.Blue;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
        }
    }
}
