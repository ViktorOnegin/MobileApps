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
            

            List<Andmed> stuf = new List<Andmed>();
            stuf.Add(
                new Andmed
                {
                    Message = "defjeslfjeslfjesfjesf",
                    Date = DateTime.Now.ToString("dd/MM/yy"),
                    Name = "Viktor Onegin"
                });

            stuf.Add(
                new Andmed
                {
                    Message = "Elu on raske",
                    Date = DateTime.Now.ToString("dd/MM/yy"),
                    Name = "Obama"
                });


            ListView list = FindViewById<ListView>(Resource.Id.listView1);
            list.Adapter = new CustomAdapter(this, stuf);
            list.ItemClick += ListView_Click;


        }

        private void ListView_Click(object sender, AdapterView.ItemClickEventArgs e)
        {
            var commentView = new Intent(this, typeof(comments));
            StartActivity(commentView);
        }

    }
}