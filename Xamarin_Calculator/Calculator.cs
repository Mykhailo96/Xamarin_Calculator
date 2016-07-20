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
        private bool FirstEnd;

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
            if(!FirstEnd)
            {
                GrowNumber(FirstNum, num, textView);
            }
            else
            {
                GrowNumber(SecondNum, num, textView);
            }
        }

        private void GrowNumber(double fOrS, double num, TextView textView)
        {
            if (fOrS != 0)
            {
                fOrS *= 10;
            }

            fOrS += num;
            textView.Text += fOrS;
        }

        public void CallAdd()
        {
            Add(FirstNum, SecondNum);
        }

        public void CallSubstract()
        {
            Substract(FirstNum, SecondNum);
        }

        public void Clear(TextView textView)
        {
            textView.Text = "";
        }

        public void CallMultiply()
        {
            Multiply(FirstNum, SecondNum);
        }
    }
}