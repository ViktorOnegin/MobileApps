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
    [Activity(Label = "comments")]
    public class comments : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Comments);

            List<Andmed> comment = new List<Andmed>();
            comment.Add(
                new Andmed
                {
                    Message = "I need your help! booi",
                    Date = DateTime.Now.ToString("dd/MM/yy"),
                    Name = "Aleksei Narusberg"
                });

            ListView list = FindViewById<ListView>(Resource.Id.listView2);
            list.Adapter = new CommentAdapter(this, comment);
        }
    }
}