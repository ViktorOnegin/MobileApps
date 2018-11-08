using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.Support.V7.App;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace XDandmed
{
    class CustomAdapter : BaseAdapter<Andmed>
    {
        List<Andmed> items;
        Activity context;
        TextView LikeNUM;
        int Count1 = 0;

        public CustomAdapter(Activity context, List<Andmed> items) : base()
        {
            this.context = context;
            this.items = items;
        }

        public override Andmed this[int position]
        {
            get { return items[position]; }
        }

        public override int Count { get { return items.Count; } }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View view1 = convertView;
            if (view1 == null)
                view1 = context.LayoutInflater.Inflate(Resource.Layout.CustomRow1, null);

            view1.FindViewById<TextView>(Resource.Id.textView1).Text = items[position].Name;
            view1.FindViewById<TextView>(Resource.Id.textView2).Text = items[position].Date;
            view1.FindViewById<TextView>(Resource.Id.textView3).Text = items[position].Message;

            View view2 = convertView;
            if (view2 == null)
                view2 = context.LayoutInflater.Inflate(Resource.Layout.CustomRow2, null);

            view2.FindViewById<TextView>(Resource.Id.textView1).Text = items[position].Name;
            view2.FindViewById<TextView>(Resource.Id.textView2).Text = items[position].Date;
            view2.FindViewById<TextView>(Resource.Id.textView3).Text = items[position].Message;

            //TextView textView = view1.FindViewById<TextView>(Resource.Id.textView3);

            LikeNUM = view1.FindViewById<TextView>(Resource.Id.textView4);

            Button LIKEbtn = view1.FindViewById<Button>(Resource.Id.button1);

            Button COMMENTbtn = view1.FindViewById<Button>(Resource.Id.button2);
            //editText.TextChanged += (object sender, Android.Text.TextChangedEventArgs e) =>
            //{
            //    textView.Text = e.Text.ToString();
            //};

            LIKEbtn.Click -= LIKEbtn_Click;
            LIKEbtn.Click += LIKEbtn_Click;

            //COMMENTbtn.Click += COMMENTbtn_Click;

            return view1;
        }

        private void LIKEbtn_Click(object sender, EventArgs e)
        {
            Count1++;
            LikeNUM.Text = "" + Count1;
        }

        //private void COMMENTbtn_Click(object sender, EventArgs e)
        //{
        //    var thirdActivity = new Intent(this, typeof(comments));
        //    StartActivity(comments);
        //}
    }
}