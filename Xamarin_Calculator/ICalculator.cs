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
    interface ICalculator
    {
        double Add(double a, double b);

        double Substract(double a, double b);

        double Multiply(double a, double b);
    }
}