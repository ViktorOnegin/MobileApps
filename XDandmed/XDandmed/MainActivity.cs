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


            var postitused = new List<Andmed>();
            Andmed post1 = new Andmed
            {
                Name = "Viktor Onegin",
                Date = DateTime.Now.ToString("dd/MM/yy"),
                Message = "defjeslfjeslfjesfjesf"
            };
            postitused.Add(post1);

            Andmed post2 = new Andmed
            {
                Name = "Viktor Onegin",
                Date = DateTime.Now.ToString("dd/MM/yy"),
                Message = "defjeslfjeslfjesfjesf"
            };
            postitused.Add(post2);

            Andmed post3 = new Andmed
            {
                Name = "Viktor Onegin",
                Date = DateTime.Now.ToString("dd/MM/yy"),
                Message = "defjeslfjeslfjesfjesf"
            };
            postitused.Add(post3);

            var list = FindViewById<ListView>(Resource.Id.listView1);

            list.Adapter = new CustomAdapter(this, postitused);
            list.ItemClick += ListView_ItemClick;


        }

        private void ListView_ItemClick(object sender, AdapterView.ItemClickEventArgs args)
        {
            var commentView = new Intent(this, typeof(comments));
            StartActivity(commentView);
        }

    }
}