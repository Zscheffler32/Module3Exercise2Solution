using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module3Exercise2Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            label1.Text = button3.Text;
            //changed label from lblMessage to label1
            //changed to button3.text
            //hotkey is alt-r
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            label1.BackColor = btnRed.BackColor;
            //changed lblMessage to label1
            //due to conflict with 'r' hotkey is alt-e
            //text is in the button but same color as background
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            label1.BackColor = btnBlue.BackColor;
            //changed lblMessage to label1
            //changed btnBlue name in the properties from button1 to btnBlue
            //hotkey is alt-b
            //text is in the button but same color as background

        }

        private void btnL_Click(object sender, EventArgs e)
        {
            label1.Text = button4.Text;
            //changed lblMessage to label1
            //hotkey is alt-l

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            //also added esc function to form
        }

       
    }
}
