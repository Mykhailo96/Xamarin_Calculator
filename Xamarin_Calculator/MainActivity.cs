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
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
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

            //button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };
        }
    }
}

