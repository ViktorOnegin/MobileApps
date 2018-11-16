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
            View view = convertView;
            if (view == null)
                view = context.LayoutInflater.Inflate(Resource.Layout.CustomRow1, null);

            view.FindViewById<TextView>(Resource.Id.textView1).Text = items[position].Name;
            view.FindViewById<TextView>(Resource.Id.textView2).Text = items[position].Date;
            view.FindViewById<TextView>(Resource.Id.textView3).Text = items[position].Message;

            int ProfilePicture = (int)typeof(Resource.Drawable).GetField(items[position].Picture).GetValue(null);
            view.FindViewById<ImageView>(Resource.Id.imageView1).SetImageResource(ProfilePicture);

            Button LIKEbtn = view.FindViewById<Button>(Resource.Id.button1);
            LikeNUM = view.FindViewById<TextView>(Resource.Id.textView4);
            LIKEbtn.Focusable = false;
            LIKEbtn.Tag = position;

            LIKEbtn.Click -= LIKEbtn_Click;
            LIKEbtn.Click += LIKEbtn_Click;

            Button COMMENTbtn = view.FindViewById<Button>(Resource.Id.button2);
            COMMENTbtn.Focusable = false;

            return view;
        }

        private void LIKEbtn_Click(object sender, EventArgs e)
        {
            Count1++;
            LikeNUM.Text = "" + Count1;
        }
    }
}