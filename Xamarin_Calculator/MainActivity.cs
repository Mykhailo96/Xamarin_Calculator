using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace Xamarin_Calculator
{
    [Activity(Label = "Xamarin_Calculator", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        Calculator calc = new Calculator();

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            TextView text = FindViewById<TextView>(Resource.Id.Text);

            FindViewById<Button>(Resource.Id.ButtonPlus).Click += (sender, e) => calc.CallAdd(text);
            FindViewById<Button>(Resource.Id.ButtonMinus).Click += (sender, e) => calc.CallSubstract(text);
            FindViewById<Button>(Resource.Id.ButtonTimes).Click += (sender, e) => calc.CallMultiply(text);
            FindViewById<Button>(Resource.Id.ButtonEqual).Click += (sender, e) => calc.Equal(text);
            FindViewById<Button>(Resource.Id.ButtonComa).Click += (sender, e) => calc.ReadComma(text);

            FindViewById<Button>(Resource.Id.Button0).Click += (sender, e) => calc.ReadNumber(0, text);
            FindViewById<Button>(Resource.Id.Button1).Click += (sender, e) => calc.ReadNumber(1, text);
            FindViewById<Button>(Resource.Id.Button2).Click += (sender, e) => calc.ReadNumber(2, text);
            FindViewById<Button>(Resource.Id.Button3).Click += (sender, e) => calc.ReadNumber(3, text);
            FindViewById<Button>(Resource.Id.Button4).Click += (sender, e) => calc.ReadNumber(4, text);
            FindViewById<Button>(Resource.Id.Button5).Click += (sender, e) => calc.ReadNumber(5, text);
            FindViewById<Button>(Resource.Id.Button6).Click += (sender, e) => calc.ReadNumber(6, text);
            FindViewById<Button>(Resource.Id.Button7).Click += (sender, e) => calc.ReadNumber(7, text);
            FindViewById<Button>(Resource.Id.Button8).Click += (sender, e) => calc.ReadNumber(8, text);
            FindViewById<Button>(Resource.Id.Button9).Click += (sender, e) => calc.ReadNumber(9, text);
            FindViewById<Button>(Resource.Id.ButtonClear).Click += (sender, e) => calc.Clear(text);

            //button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };
        }
    }
}

