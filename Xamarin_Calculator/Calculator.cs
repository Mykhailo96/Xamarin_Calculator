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
        private double FirstNum;
        private double SecondNum;
        private double Result;
        char operation;
        private bool FirstEnd = false;

        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Multiply(double a, double b)
        {
            return a - b;
        }

        public double Substract(double a, double b)
        {
            return a * b;
        }

        public void ReadComa()
        {
            throw new NotImplementedException();
        }

        public void ReadNumber(double num, TextView textView)
        {
            if (!FirstEnd)
            {
                //GrowNumber(FirstNum, num, textView);
                if (FirstNum == 0 && num == 0)
                    return;
                if (FirstNum != 0)
                {
                    textView.Text = "";
                    FirstNum *= 10;
                }
                
                FirstNum += num;
                textView.Text += FirstNum;
            }
            else
            {
                if (SecondNum == 0 && num == 0)
                    return;
                if (SecondNum != 0)
                {
                    textView.Text = FirstNum.ToString() + operation;
                    SecondNum *= 10;
                }

                SecondNum += num;
                textView.Text += SecondNum;
                //GrowNumber(SecondNum, num, textView);
            }
        }



        private void GrowNumber(double fOrS, double num, TextView textView)
        {
            if (fOrS == 0 && num == 0)
                return;

            if (fOrS != 0)
            {
                fOrS *= 10;
            }

            fOrS += num;
            //textView.Text.Remove(0, fOrS.ToString().Length);
            textView.Text += fOrS;
        }

        public void CallAdd(TextView textView)
        {
            FirstEnd = true;
            operation = '+';
            textView.Text += "+";
        }

        public void CallSubstract(TextView textView)
        {
            FirstEnd = true;
            operation = '-';
            textView.Text += "-";
        }

        public void CallMultiply(TextView textView)
        {
            FirstEnd = true;
            operation = '*';
            textView.Text += "*";
        }

        public void Clear(TextView textView)
        {
            textView.Text = "";
            FirstNum = 0;
            SecondNum = 0;
            FirstEnd = false;
        }

        public void Equal(TextView textView)
        {
            textView.Text += "=";
            switch (operation)
            {
                case '+':
                    textView.Text += Add(FirstNum, SecondNum);
                    break;
                default:
                    break;
            }
        }
    }
}