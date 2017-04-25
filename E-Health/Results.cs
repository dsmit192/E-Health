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
    [Activity(Label ="ListView", MainLauncher = true, Icon ="@drawable/icon")]
    public class Results : Activity
    {
  
        private List<string> mItems;
        private ListView mListView;

        protected override void OnCreate(Bundle bundle)
        {
                base.OnCreate(bundle);
                SetContentView(Resource.Layout.Main);
                mListView = FindViewById<ListView>(Resource.Id.myListView);

                mItems = new List<string>();
                mItems.Add("Run more");
                mItems.Add("Drink more water");
                mItems.Add("Hav less stress");

                ArrayAdapter<string> adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, mItems);

            mListView.Adapter = adapter;
            }
        }
    }