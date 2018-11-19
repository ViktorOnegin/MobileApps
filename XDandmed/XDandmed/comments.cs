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

            var list = FindViewById<ListView>(Resource.Id.listView1);
            list.Adapter = new CommentAdapter(this, values.cmt);

            var AddCommentBtn = FindViewById<Button>(Resource.Id.button1);
            AddCommentBtn.Click += addCommentBtn_Click;
        }

        private void addCommentBtn_Click(object sender , EventArgs e)
        {
            string AddComment = FindViewById<EditText>(Resource.Id.textView1).Text;

            values.cmt.Add(new Comment
            {
                name = "Uus kasutaja",
                picture = "image4",
                date = DateTime.Now.ToString("dd/MM/yy"),
                message = AddComment
            });

            
            var list = FindViewById<ListView>(Resource.Id.listView1);
            list.Adapter = new CommentAdapter(this, values.cmt);
        }
    }
}