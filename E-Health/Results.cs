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

namespace E_Health.Resources
{
    [Activity(Label = "Results")]
    public class Results : Activity
    {
        TextView ScoreView;
        String healtyScore
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Results);
            //  string textvb = Intent.GetStringExtra("MyData") ?? "Data not available";
            double numberScore = Intent.GetDoubleExtra("MyData", 0.0);
           ScoreView = FindViewById<TextView>(Resource.Id.textScore);
            if (numberScore < 75)
            {
                ScoreView.Text = "Very unhealthy";
                if (numberScore < 50)
                {
                    ScoreView.Text = "Unhealthy";
                    if (numberScore < 35)
                    {
                        ScoreView.Text = "Healthy";
                    }
                }
            }  
        }
    }
}