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
using WeatherApp.Core;

namespace WeatherApp
{
    [Activity(Label = "SecondActivity")]
    public class SecondActivity : AppCompatActivity
    {
        ListView list;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Second_Activity);

            // Create your application here

            list = FindViewById<ListView>(Resource.Id.listView1);

            LoadWeather();
            
            //ListView.ItemClick += ListView_ItemClick;

        }

        public async void LoadWeather()
        {
            var weathers = await Core.Core.GetForecast("tallinn");

            list.Adapter = new CustomAdapter(this, weathers);
        }

        public void ListView_ItemClick(object sender, AdapterView.ItemClickEventArgs args)
        {
            Toast.MakeText(Application, ((TextView)args.View).Text, ToastLength.Long).Show();
        }
    }
}