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

            int ProfilePicture = (int)typeof(Resource.Drawable).GetField(items[position].picture).GetValue(null);
            view1.FindViewById<ImageView>(Resource.Id.imageView1).SetImageResource(ProfilePicture);

            Button LIKEbtn = view1.FindViewById<Button>(Resource.Id.button1);
            LikeNUM = view1.FindViewById<TextView>(Resource.Id.textView4);
            LIKEbtn.Focusable = false;

            Button COMMENTbtn = view1.FindViewById<Button>(Resource.Id.button2);
            COMMENTbtn.Focusable = false;
            
            LIKEbtn.Click -= LIKEbtn_Click;
            LIKEbtn.Click += LIKEbtn_Click;

            return view1;
        }

        private void LIKEbtn_Click(object sender, EventArgs e)
        {
            Count1++;
            LikeNUM.Text = "" + Count1;
        }
    }
}