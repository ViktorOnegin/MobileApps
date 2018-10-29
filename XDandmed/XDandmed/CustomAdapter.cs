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

namespace XDandmed
{
    public class CustomAdapter : BaseAdapter<string>
    {
        List<string> items;
        Activity context;

        public CustomAdapter(Activity context, List<string> items) : base()
        {
            this.context = context;
            this.items = items;
        }

        public override string this[int position]
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
                view = context.LayoutInflater.Inflate(Resource.Layout.CustomRow, null);
            
            //view.FindViewById<ImageView>(Resource.Id.imageView1).Text = items[position];
            view.FindViewById<TextView>(Resource.Id.textView1).Text = items[position];
            view.FindViewById<TextView>(Resource.Id.textView2).Text = items[position];
            view.FindViewById<EditText>(Resource.Id.textView4).Text = items[position];
            view.FindViewById<Button>(Resource.Id.nupp1).Text = items[position];
            view.FindViewById<Button>(Resource.Id.button2).Text = items[position];
            view.FindViewById<TextView>(Resource.Id.textView5).Text = items[position];
            view.FindViewById<TextView>(Resource.Id.textView6).Text = items[position];

            return view;
        }
    }
}