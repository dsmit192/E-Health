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
        Button submitButton;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView (Resource.Layout.Main);
            submitButton = FindViewById<Button>(Resource.Id.submitButton);
            submitButton.Click += helpButton_Click;
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(Results));
            intent.PutExtra("MyData", "55");
            StartActivity(intent);
        }
    }
}
