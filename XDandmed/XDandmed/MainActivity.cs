using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System.Collections.Generic;
using System;
using Android.Content;

namespace XDandmed
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        public List<Andmed> postitused;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            postitused = new List<Andmed>();
            Andmed post1 = new Andmed
            {
                Name = "Viktor Onegin",
                Picture = "image3",
                Date = DateTime.Now.ToString("dd/MM/yy"),
                Message = "app töötab",

                Cmt = new List<Comment>()
                {
                     new Comment
                     {
                         name = "Bob",
                         picture = "image",
                         date = DateTime.Now.ToString("dd/MM/yy"),
                         message = "How to play fortnite"
                     }
                }
            };
            postitused.Add(post1);

            Andmed post2 = new Andmed
            {
                Name = "ninja",
                Picture = "image1",
                Date = DateTime.Now.ToString("dd/MM/yy"),
                Message = "#1 victory royale ",

                Cmt = new List<Comment>()
                {
                     new Comment
                     {
                         name = "joker",
                         picture = "image2",
                         date = DateTime.Now.ToString("dd/MM/yy"),
                         message = "fortnite is gay"
                     }
                }
            };
            postitused.Add(post2);

            Andmed post3 = new Andmed
            {
                Name = "Dude",
                Picture = "image5",
                Date = DateTime.Now.ToString("dd/MM/yy"),
                Message = "i'm not gay",

                Cmt = new List<Comment>()
                {
                     new Comment
                     {
                         name = "Aafrika neeger",
                         picture = "image6",
                         date = DateTime.Now.ToString("dd/MM/yy"),
                         message = "nibbaswitniggas"
                     }
                }
            };
            postitused.Add(post3);

            var list = FindViewById<ListView>(Resource.Id.listView1);
            list.Adapter = new CustomAdapter(this, postitused);
            list.ItemClick += ListView_ItemClick;

            var AddPostBtn = FindViewById<Button>(Resource.Id.button1);
            AddPostBtn.Click += addPostBtn_Click;

        }

        private void ListView_ItemClick(object sender, AdapterView.ItemClickEventArgs args)
        {
            var commentView = new Intent(this, typeof(comments));
            values.cmt = postitused[args.Position].Cmt;
            StartActivity(commentView);
        }

        private void addPostBtn_Click(object sender, System.EventArgs e)
        {
            postitused.Add(new Andmed
            {
                Name = "Uus Kasutaja",
                Picture = "image4",
                Date = DateTime.Now.ToString("dd/MM/yy"),
                Message = "Text",

                Cmt = new List<Comment>()
                {
                    new Comment
                    {
                         name = "Uus kasutaja",
                         picture = "imaga4",
                         date = DateTime.Now.ToString("dd/MM/yy"),
                         message = "tekst"
                    }
                }
            });

            var list = FindViewById<ListView>(Resource.Id.listView1);
            list.Adapter = new CustomAdapter(this, postitused);
 
        }

    }
}