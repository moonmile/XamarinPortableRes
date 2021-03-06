﻿using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using XamarinPortableRes.Lib.Properties;

namespace XamarinPortableRes.Android
{


    [Activity(Label = "XamarinPortableRes.Android", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;
        ImageView imageBlue, imageGreen, imageOrange, imagePurple, imageRed;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.MyButton);
            button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };

            // text content
            FindViewById<TextView>(Resource.Id.textView1).Text = 
                XamarinPortableRes.Lib.Properties.Resources.Message1;

            this.imageBlue = FindViewById<ImageView>(Resource.Id.imageView1);
            this.imageGreen = FindViewById<ImageView>(Resource.Id.imageView2);
            this.imageOrange = FindViewById<ImageView>(Resource.Id.imageView3);
            this.imagePurple = FindViewById<ImageView>(Resource.Id.imageView4);
            this.imageRed = FindViewById<ImageView>(Resource.Id.imageView5);
            // image contents
            imageBlue.SetImageBitmap(XamarinPortableRes.Lib.Resources.MarkBlue.ToBitmap());
            imageGreen.SetImageBitmap(XamarinPortableRes.Lib.Resources.MarkGreen.ToBitmap());
            imageOrange.SetImageBitmap(XamarinPortableRes.Lib.Resources.MarkOrange.ToBitmap());
            imagePurple.SetImageBitmap(XamarinPortableRes.Lib.Resources.MarkPurple.ToBitmap());
            imageRed.SetImageBitmap(XamarinPortableRes.Lib.Resources.MarkRed.ToBitmap());
        }

    }
    public static class StreamExtentions {
        public static global::Android.Graphics.Bitmap ToBitmap( this System.IO.Stream st ) {
            using (var mem = new System.IO.MemoryStream())
            {
                st.CopyTo(mem);
                st.Close();
                var data = mem.ToArray();
                var bmp = global::Android.Graphics.BitmapFactory.DecodeByteArray(data, 0, data.Length);
                return bmp;
            }
        }
    }
}

