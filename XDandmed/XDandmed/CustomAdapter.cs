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
    class CustomAdapter : BaseAdapter<Andmed>
    {
        List<Andmed> items;
        Activity context;
        TextView LikeNUM;
        TextView DislikeNUM;
        int Count1 = 0;
        int Count2 = 0;

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
                view = context.LayoutInflater.Inflate(Resource.Layout.CustomRow, null);
            
            view.FindViewById<TextView>(Resource.Id.textView1).Text = items[position].Name;
            view.FindViewById<TextView>(Resource.Id.textView2).Text = items[position].Date;

            EditText editText = view.FindViewById<EditText>(Resource.Id.editText1);
            TextView textView = view.FindViewById<TextView>(Resource.Id.textView3);

            LikeNUM = view.FindViewById<TextView>(Resource.Id.textView4);
            DislikeNUM = view.FindViewById<TextView>(Resource.Id.textView5);

            Button LIKEbtn = view.FindViewById<Button>(Resource.Id.button1);
            Button DISLIKEbtn = view.FindViewById<Button>(Resource.Id.button2);

            editText.TextChanged += (object sender, Android.Text.TextChangedEventArgs e) =>
            {
                textView.Text = e.Text.ToString();
            };

            LIKEbtn.Click -= LIKEbtn_Click;
            LIKEbtn.Click += LIKEbtn_Click;

            DISLIKEbtn.Click -= DISLIKEbtn_Click;
            DISLIKEbtn.Click += DISLIKEbtn_Click;

            return view;
        }

        private void DISLIKEbtn_Click(object sender, EventArgs e)
        {
            Count2++;
            DislikeNUM.Text = "" + Count2;
        }

        private void LIKEbtn_Click(object sender, EventArgs e)
        {
            Count1++;
            LikeNUM.Text = "" + Count1;
        }
    }
}