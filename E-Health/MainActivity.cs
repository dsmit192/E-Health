using Android.App;
using Android.Widget;
using Android.OS;

namespace E_Health
{
    [Activity(Label = "E_Health", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
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

