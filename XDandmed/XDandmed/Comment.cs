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

namespace XDandmed
{
    public class Comment
    {
        public string name { get; set; }
        public string date { get; set; }
        public string message { get; set; }
        public string picture { get; set; }
    }
}