using Android.App;
using Android.Content.Res;
using Android.OS;
using Android.Widget;
using E_Health.Resources;
using Xamarin.Android;
using System.Collections.Generic;
using System;
using Android.Content;

namespace E_Health
{
    // Show the splash screen
    [Activity(Theme = "@style/MyTheme.Splash", MainLauncher = true)]
    public class SplashActivity : Activity
    {
     
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            this.StartActivity(typeof(MainActivity));
           
        }
    }
    //Show the main view
    [Activity(Label = "E_Health", Theme = "@android:style/Theme.Holo", MainLauncher = false)]
    public class MainActivity : Activity
    {
        Double number;
        Button submitButton;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            EditText editHeight = FindViewById<EditText>(Resource.Id.HeightInput);
            EditText editWeight = FindViewById<EditText>(Resource.Id.WeightInput);
            EditText editBP = FindViewById<EditText>(Resource.Id.BloodPressureInput);
            EditText editTemp = FindViewById<EditText>(Resource.Id.TemperatureInput);
            Button SubmitBtn = FindViewById<Button>(Resource.Id.SubmitButton);
            RatingBar RatingFeeling = FindViewById<RatingBar>(Resource.Id.RatingBar);
            TextView CheckResult = FindViewById<TextView>(Resource.Id.TESTING);
            SubmitBtn.Click += (object sender, System.EventArgs e) =>
            {
                int n;
                n = int.Parse(editWeight.Text) +
                    int.Parse(editTemp.Text) +
                    int.Parse(editHeight.Text) +
                    int.Parse(editBP.Text);
                CheckResult.Text = n + "";
            };
        }
    }
}
