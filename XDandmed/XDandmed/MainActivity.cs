using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System.Collections.Generic;
using Android.Content;
using System;

namespace XDandmed
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            //var List = new List<Andmed>();
            //Andmed andmed = new Andmed
            //{
            //    Date = "20.02.2012",
            //    Name = "Viktor Onegin"
            //};
            //List.Add(andmed);

            List<Andmed> stuf = new List<Andmed>();
            stuf.Add(
                new Andmed
                {
                    Date = DateTime.Now.ToString("dd/MM/yy"),
                    Name = "Viktor Onegin"
                });

            //stuf.Add(
            //    new Andmed
            //    {
            //        Date = "20.02.2012",
            //        Name = "Obama"
            //    });

            ListView list = FindViewById<ListView>(Resource.Id.listView1);
            list.Adapter = new CustomAdapter(this, stuf);

        }

    }
}