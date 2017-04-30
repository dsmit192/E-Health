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
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Results);
            string textvb = Intent.GetStringExtra("MyData") ?? "Data not available";
           ScoreView = FindViewById<TextView>(Resource.Id.textScore);
            ScoreView.Text = textvb;
        }
    }
}