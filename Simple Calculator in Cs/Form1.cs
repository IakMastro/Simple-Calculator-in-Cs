using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Calculator_in_Cs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void oneBtn_Click(object sender, EventArgs e)
        {
            screenCB.SelectedText = "1";
        }

        private void twoBtn_Click(object sender, EventArgs e)
        {
            screenCB.SelectedText = "2";
        }

        private void threeBtn_Click(object sender, EventArgs e)
        {
            screenCB.SelectedText = "3";
        }

        private void fourBtn_Click(object sender, EventArgs e)
        {
            screenCB.SelectedText = "4";
        }

        private void fiveBtn_Click(object sender, EventArgs e)
        {
            screenCB.SelectedText = "5";
        }

        private void sixBtn_Click(object sender, EventArgs e)
        {
            screenCB.SelectedText = "6";
        }

        private void sevenBtn_Click(object sender, EventArgs e)
        {
            screenCB.SelectedText = "7";
        }

        private void eightBtn_Click(object sender, EventArgs e)
        {
            screenCB.SelectedText = "8";
        }

        private void nineBtn_Click(object sender, EventArgs e)
        {
            screenCB.SelectedText = "9";
        }

        private void zeroBtn_Click(object sender, EventArgs e)
        {
            screenCB.SelectedText = "0";
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            screenCB.SelectedText = " + ";
        }

        private void subBtn_Click(object sender, EventArgs e)
        {
            screenCB.SelectedText = " - ";
        }

        private void multBtn_Click(object sender, EventArgs e)
        {
            screenCB.SelectedText = " * ";
        }

        private void divBtn_Click(object sender, EventArgs e)
        {
            screenCB.SelectedText = " / ";
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            screenCB.Clear();
        }
    }
}
