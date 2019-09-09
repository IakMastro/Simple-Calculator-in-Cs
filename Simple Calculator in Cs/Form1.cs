using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Calculator_in_Cs
{
    public partial class Form1 : Form
    {
        Stack<double> valueStack;
        Stack<char> operatorStack;
        public Form1()
        {
            InitializeComponent();
            valueStack = new Stack<double>();
            operatorStack = new Stack<char>();
        }

        private void oneBtn_Click(object sender, EventArgs e)
        {
            screenCB.SelectedText = "1";
            valueStack.Push(1);
        }

        private void twoBtn_Click(object sender, EventArgs e)
        {
            screenCB.SelectedText = "2";
            valueStack.Push(2);
        }

        private void threeBtn_Click(object sender, EventArgs e)
        {
            screenCB.SelectedText = "3";
            valueStack.Push(3);
        }

        private void fourBtn_Click(object sender, EventArgs e)
        {
            screenCB.SelectedText = "4";
            valueStack.Push(4);
        }

        private void fiveBtn_Click(object sender, EventArgs e)
        {
            screenCB.SelectedText = "5";
            valueStack.Push(5);
        }

        private void sixBtn_Click(object sender, EventArgs e)
        {
            screenCB.SelectedText = "6";
            valueStack.Push(6);
        }

        private void sevenBtn_Click(object sender, EventArgs e)
        {
            screenCB.SelectedText = "7";
            valueStack.Push(7);
        }

        private void eightBtn_Click(object sender, EventArgs e)
        {
            screenCB.SelectedText = "8";
            valueStack.Push(8);
        }

        private void nineBtn_Click(object sender, EventArgs e)
        {
            screenCB.SelectedText = "9";
            valueStack.Push(9);
        }

        private void zeroBtn_Click(object sender, EventArgs e)
        {
            screenCB.SelectedText = "0";
            valueStack.Push(0);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            screenCB.SelectedText = "+";
            operatorStack.Push('+');
        }

        private void subBtn_Click(object sender, EventArgs e)
        {
            screenCB.SelectedText = "-";
            operatorStack.Push('-');
        }

        private void multBtn_Click(object sender, EventArgs e)
        {
            screenCB.SelectedText = "*";
            operatorStack.Push('*');
        }

        private void divBtn_Click(object sender, EventArgs e)
        {
            screenCB.SelectedText = "/";
            operatorStack.Push('/');
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            screenCB.Clear();
            valueStack.Clear();
            operatorStack.Clear();
        }

        private void equalsBtn_Click(object sender, EventArgs e)
        {
            isEmpty();
        }

        private bool isEmpty()
        {
            IList<double> list = new List<double>();
            if (operatorStack.Count != 0)
            {
                string[] numbers = Regex.Split(screenCB.Text, @"[^\d\.]");
                
                foreach (string value in numbers)
                {

                    if (!string.IsNullOrEmpty(value))
                    {

                        list.Add(Double.Parse(value));

                    }

                }

                char op = operatorStack.Pop();
                double num2 = valueStack.Pop();

                int count = 1;
                for(int i = valueStack.Count; i > -1; i--)
                {
     
                    if (list[1].Equals(num2)) break;

                    num2 += valueStack.Pop() * Math.Pow(10, count);
                    count++;

                }

                double num1 = valueStack.Pop();
                count = 1;
                for(int i = valueStack.Count; i > -1; i--)
                {

                    if (list[0].Equals(num1)) break;

                    num1 += valueStack.Pop() * Math.Pow(10, count);
                    count++;

                }
                screenCB.Clear();

                switch (op)
                {
                    case '+':
                        calculatorAdd(num1, num2);
                        break;

                    case '-':
                        calculatorSub(num1, num2);
                        break;

                    case '*':
                        calculatorMult(num1, num2);
                        break;

                    case '/':
                        calculatorDiv(num1, num2);
                        break;
                }

                list.Clear();

                return false;
            }

            return true;
        }

        private void calculatorAdd(double num1, double num2)
        {

            double sum = num1 + num2;
            screenCB.SelectedText = sum.ToString();
            valueStack.Push(sum);

        }
        private void calculatorSub(double num1, double num2)
        {

            double sum = num1 - num2;
            screenCB.SelectedText = sum.ToString();
            valueStack.Push(sum);

        }
        private void calculatorMult(double num1, double num2)
        {

            double sum = num1 * num2;
            screenCB.SelectedText = sum.ToString();
            valueStack.Push(sum);

        }
        private void calculatorDiv(double num1, double num2)
        {

            double sum = num1 / num2;
            screenCB.SelectedText = sum.ToString();
            valueStack.Push(sum);

        }
    }
}
