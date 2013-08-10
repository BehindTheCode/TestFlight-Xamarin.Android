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
    [Activity(Label = "Dot Net Crash Activity")]
    public class DotNetCrashActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.activity_testLayout);

            TextView textView1 = FindViewById<TextView>(Resource.Id.textview1);
            Button button1 = FindViewById<Button>(Resource.Id.button1);

            if (textView1 != null)
                textView1.Text = "This activity will error in the .Net code.";

            if (button1 != null)
                button1.Click += Button1_Click;
        }

        void Button1_Click(object sender, EventArgs e)
        {
            // Throw an error in .NET code.
            throw new ApplicationException("App is throwing an error.");
        }
    }
}