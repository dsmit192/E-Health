using Android.App;
using Android.Content.Res;
using Android.OS;
using Android.Widget;
using E_Health.Resources;
using Xamarin.Android;
using System.Collections.Generic;
using System;

namespace E_Health
{
    // Show the splash screen
    [Activity(Theme = "@style/MyTheme.Splash", MainLauncher = true, NoHistory = true)]
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
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView (Resource.Layout.Main);
            Button nextbutton = FindViewById<Button>(Resource.Id.button1);
            nextbutton.Click += delegate
            {
         SetContentView(Resource.Layout.Results);
            };
        }
    }
}
