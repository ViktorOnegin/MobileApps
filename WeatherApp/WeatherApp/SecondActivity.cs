using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;

namespace WeatherApp
{
    [Activity(Label = "SecondActivity")]
    public class SecondActivity : AppCompatActivity
    {
        string[] countries = new string[] { "Eesti", "Soome", "Rootsi" };

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Second_Activity);

            // Create your application here

            var list = FindViewById<ListView>(Resource.Id.listView1);

            list.Adapter = new CustomAdapter(this, countries);
            //ListView.ItemClick += ListView_ItemClick;

        }

        public void ListView_ItemClick(object sender, AdapterView.ItemClickEventArgs args)
        {
            Toast.MakeText(Application, ((TextView)args.View).Text, ToastLength.Long).Show();
        }
    }
}