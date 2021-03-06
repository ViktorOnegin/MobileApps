﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using WeatherApp.Core;

namespace WeatherApp
{
    public class CustomAdapter : BaseAdapter<Forecast>
    {
        Forecast[] items;
        Activity context;

        public CustomAdapter(Activity context, Forecast[] items) : base()
        {
            this.context = context;
            this.items = items;
        }

        public override Forecast this[int position]
        {
            get { return items[position]; }
        }

        public override int Count
        {
            get { return items.Length; }
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View view = convertView;
            if (view == null)
                view = context.LayoutInflater.Inflate(Resource.Layout.CustomRow , null);

            //var icon = view.FindViewById<ImageView>(Resource.Id.imageView1);

            view.FindViewById<TextView>(Resource.Id.textView1).Text = items[position].data;
            view.FindViewById<TextView>(Resource.Id.textView2).Text = items[position].TemperatureMin;
            view.FindViewById<TextView>(Resource.Id.textView4).Text = items[position].TemperatureMax;

            return view;


        }
    }
}