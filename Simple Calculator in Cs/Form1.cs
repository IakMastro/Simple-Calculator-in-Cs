using System;
using System.Collections;
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
        Stack<int> valueStack;
        Stack<char> operatorStack;
        static int counter = 0;
        public Form1()
        {
            InitializeComponent();
            valueStack = new Stack<int>();
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
            screenCB.SelectedText = " + ";
            operatorStack.Push('+');
        }

        private void subBtn_Click(object sender, EventArgs e)
        {
            screenCB.SelectedText = " - ";
            operatorStack.Push('-');
        }

        private void multBtn_Click(object sender, EventArgs e)
        {
            screenCB.SelectedText = " * ";
            operatorStack.Push('*');
        }

        private void divBtn_Click(object sender, EventArgs e)
        {
            screenCB.SelectedText = " / ";
            operatorStack.Push('/');
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            screenCB.Clear();
        }

        private void equalsBtn_Click(object sender, EventArgs e)
        {
            isEmpty();
        }

        private bool isEmpty()
        {
            if(operatorStack.Count != 0)
            {
                char op = operatorStack.Pop();
                int num2 = valueStack.Pop();
                int num1 = valueStack.Pop();
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

                return false;
            }

            return true;
        }

        private void calculatorAdd(int num1, int num2)
        {

            int sum = num1 + num2;
            screenCB.SelectedText = sum.ToString();
            valueStack.Push(sum);

        }
        private void calculatorSub(int num1, int num2)
        {

            int sum = num1 - num2;
            screenCB.SelectedText = sum.ToString();
            valueStack.Push(sum);

        }
        private void calculatorMult(int num1, int num2)
        {

            int sum = num1 * num2;
            screenCB.SelectedText = sum.ToString();
            valueStack.Push(sum);

        }
        private void calculatorDiv(int num1, int num2)
        {

            int sum = num1 / num2;
            screenCB.SelectedText = sum.ToString();
            valueStack.Push(sum);

        }
    }
}
