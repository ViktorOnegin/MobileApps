using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System.Collections.Generic;

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

            var editText = FindViewById<EditText>(Resource.Id.editText1);
            var textView = FindViewById<TextView>(Resource.Id.textView3);
            editText.TextChanged += (object sender, Android.Text.TextChangedEventArgs e) =>
            {
                textView.Text = e.Text.ToString();
            };


            int count1 = 0;
            int count2 = 0;
            var LIKEbtn = FindViewById<Button>(Resource.Id.button1);
            var DISLIKEbtn = FindViewById<Button>(Resource.Id.button2);

            var likeNUM = FindViewById<TextView>(Resource.Id.textView4);
            var dislikeNUM = FindViewById<TextView>(Resource.Id.textView5);

            LIKEbtn.Click += delegate
            {
                count1++;
                likeNUM.Text = "" + count1;
            };

            DISLIKEbtn.Click += delegate
            {
                count2++;
                dislikeNUM.Text = "" + count2;
            };

            List<Andmed> stuf = new List<Andmed>();
            stuf.Add(
                new Andmed
                {
                    Date = "20.02.2012",
                    Name = "Viktor Onegin"
                });

            ListView list = FindViewById<ListView>(Resource.Id.listView1);
            list.Adapter = new CustomAdapter(this, stuf);

        }

    }
}