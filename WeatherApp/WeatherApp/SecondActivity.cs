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

namespace WeatherApp
{
    [Activity(Label = "SecondActivity")]
    public class SecondActivity : ListActivity
    {
        string[] countries = new string[] { "Eesti", "Soome", "Rootsi" };

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            //SetContentView(Resource.Layout.Second_Activity);

            // Create your application here

            ListAdapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleExpandableListItem1, countries);
            ListView.ItemClick += ListView_ItemClick;

        }

        public void ListView_ItemClick(object sender, AdapterView.ItemClickEventArgs args)
        {
            Toast.MakeText(Application, ((TextView)args.View).Text, ToastLength.Long).Show();
        }
    }
}