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

            // Get our button from the layout resource,
            // and attach an event to it
            TextView text = FindViewById<TextView>(Resource.Id.Text);

            Button buttonPlus = FindViewById<Button>(Resource.Id.ButtonPlus);
            Button buttonMinus = FindViewById<Button>(Resource.Id.ButtonMinus);
            Button buttonTimes = FindViewById<Button>(Resource.Id.ButtonTimes);
            Button buttonEqual = FindViewById<Button>(Resource.Id.ButtonEqual);

            Button button1 = FindViewById<Button>(Resource.Id.Button1);
            Button button2 = FindViewById<Button>(Resource.Id.Button2);
            Button button3 = FindViewById<Button>(Resource.Id.Button3);
            Button button4 = FindViewById<Button>(Resource.Id.Button4);
            Button button5 = FindViewById<Button>(Resource.Id.Button5);
            Button button6 = FindViewById<Button>(Resource.Id.Button6);
            Button button7 = FindViewById<Button>(Resource.Id.Button7);
            Button button8 = FindViewById<Button>(Resource.Id.Button8);
            Button button9 = FindViewById<Button>(Resource.Id.Button9);
            Button button0 = FindViewById<Button>(Resource.Id.Button0);
            Button buttonComa = FindViewById<Button>(Resource.Id.ButtonComa);
            Button buttonClear = FindViewById<Button>(Resource.Id.ButtonClear);

            button0.Click += (sender, e) => calc.ReadNumber(0, text);
            button1.Click += (sender, e) => calc.ReadNumber(1, text);
            button2.Click += (sender, e) => calc.ReadNumber(2, text);
            button3.Click += (sender, e) => calc.ReadNumber(3, text);
            button4.Click += (sender, e) => calc.ReadNumber(4, text);
            button5.Click += (sender, e) => calc.ReadNumber(5, text);
            button6.Click += (sender, e) => calc.ReadNumber(6, text);
            button7.Click += (sender, e) => calc.ReadNumber(7, text);
            button8.Click += (sender, e) => calc.ReadNumber(8, text);
            button9.Click += (sender, e) => calc.ReadNumber(9, text);
            buttonClear.Click += (sender, e) => calc.Clear(text);

            //button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };
        }
    }
}

