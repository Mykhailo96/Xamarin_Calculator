using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Xamarin_Calculator
{
    class Calculator : ICalculator
    {
        private double firstNum;

        private double secondNum;

        private bool result = false;

        private int power = 1;

        private bool comma = false;

        char operation;

        private bool firstEnd = false;

        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Substract(double a, double b)
        {
            return a - b;
        }

        public void ReadComma(TextView textView)
        {
            comma = true;
        }

        public void ReadNumber(double num, TextView textView)
        {
            if (!firstEnd)
            {
                if (firstNum == 0 && num == 0)
                {
                    textView.Text = "0.";
                    comma = true;
                }
                else if(comma)
                {
                    firstNum += num / Math.Pow(10, power++);
                    textView.Text = firstNum.ToString();
                }
                else if (firstNum != 0)
                {
                    textView.Text = "";
                    firstNum *= 10;
                    firstNum += num;
                    textView.Text = firstNum.ToString();
                }
                else if(firstNum == 0)
                {
                    firstNum = num;
                    textView.Text = firstNum.ToString();
                }
            }
            else
            {
                if (secondNum == 0 && num == 0)
                {
                    textView.Text = firstNum.ToString() + operation + "0.";
                    comma = true;
                }
                else if (comma)
                {
                    secondNum += num / Math.Pow(10, power++);
                    textView.Text = firstNum.ToString() + operation + secondNum.ToString();
                }
                else if (secondNum != 0)
                {
                    textView.Text = "";
                    secondNum *= 10;
                    secondNum += num;
                    textView.Text = firstNum.ToString() + operation + secondNum.ToString();
                }
                else if (secondNum == 0)
                {
                    secondNum = num;
                    textView.Text = firstNum.ToString() + operation + secondNum.ToString();
                }
            }
        }

        public void CallAdd(TextView textView)
        {
            switch (operation)
            {
                case '+':
                    {
                        firstNum = Add(firstNum, secondNum);
                        textView.Text = firstNum.ToString();
                    }
                    break;
                case '-':
                    {
                        firstNum = Substract(firstNum, secondNum);
                        textView.Text = firstNum.ToString();
                    }
                    break;
                case '*':
                    {
                        firstNum = Multiply(firstNum, secondNum);
                        textView.Text = firstNum.ToString();
                    }
                    break;
                default:
                    break;
            }

            secondNum = 0;
            firstEnd = true;
            operation = '+';
            power = 1;
            comma = false;
            result = false;

            textView.Text += "+";
        }

        public void CallSubstract(TextView textView)
        {
            switch (operation)
            {
                case '+':
                    {
                        firstNum = Add(firstNum, secondNum);
                        textView.Text = firstNum.ToString();
                    }
                    break;
                case '-':
                    {
                        firstNum = Substract(firstNum, secondNum);
                        textView.Text = firstNum.ToString();
                    }
                    break;
                case '*':
                    {
                        firstNum = Multiply(firstNum, secondNum);
                        textView.Text = firstNum.ToString();
                    }
                    break;
                default:
                    break;
            }

            secondNum = 0;
            firstEnd = true;
            operation = '-';
            power = 1;
            comma = false;
            result = false;

            textView.Text += "-";
        }

        public void CallMultiply(TextView textView)
        {
            switch (operation)
            {
                case '+':
                    {
                        firstNum = Add(firstNum, secondNum);
                        textView.Text = firstNum.ToString();
                    }
                    break;
                case '-':
                    {
                        firstNum = Substract(firstNum, secondNum);
                        textView.Text = firstNum.ToString();
                    }
                    break;
                case '*':
                    {
                        firstNum = Multiply(firstNum, secondNum);
                        textView.Text = firstNum.ToString();
                    }
                    break;
                default:
                    break;
            }

            secondNum = 0;
            firstEnd = true;
            operation = '*';
            power = 1;
            comma = false;
            result = false;

            textView.Text += "*";
        }

        public void Clear(TextView textView)
        {
            textView.Text = "";
            firstNum = 0;
            secondNum = 0;
            firstEnd = false;
            power = 1;
            comma = false;
            result = false;
        }

        public void CancelNumber(TextView textView)
        {
            //if(firstEnd)
            //{
            //    textView.Text = firstNum.ToString() + operation;
            //}
            //else
            //{
            //    textView.Text = "";
            //}

            textView.Text += "";
        }

        public void Equal(TextView textView)
        {
            if (result)
                return;

            result = true;

            switch (operation)
            {
                case '+':
                    {
                        firstNum = Add(firstNum, secondNum);
                        textView.Text = firstNum.ToString();
                    }
                    break;
                case '-':
                    {
                        firstNum = Substract(firstNum, secondNum);
                        textView.Text = firstNum.ToString();
                    }
                    break;
                case '*':
                    {
                        firstNum = Multiply(firstNum, secondNum);
                        textView.Text = firstNum.ToString();
                    }
                    break;
                default:
                    break;
            }

            secondNum = 0;
            power = 1;
            comma = false;
        }
    }
}