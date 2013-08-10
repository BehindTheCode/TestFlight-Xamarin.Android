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

namespace TestFlightSampleApp
{
    [Activity(Label = "Test Flight Sample", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.activity_main);

            // Get our buttons from the layout resource, and attach a click event to it.
            Button button1 = FindViewById<Button>(Resource.Id.button1);
            Button button2 = FindViewById<Button>(Resource.Id.button2);
            Button button3 = FindViewById<Button>(Resource.Id.button3);
            
            if (button1 != null)
                button1.Click += delegate { StartActivity(typeof(DotNetCrashActivity)); };

            if (button2 != null)
                button2.Click += delegate { StartActivity(typeof(JavaCrashActivity)); };

            if (button3 != null)
                button3.Click += delegate { StartActivity(typeof(CheckpointActivity)); };
        }
    }
}