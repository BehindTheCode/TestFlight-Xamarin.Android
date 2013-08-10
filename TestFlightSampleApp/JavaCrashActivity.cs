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
    [Activity(Label = "Java Crash Activity")]
    public class JavaCrashActivity : Activity
    {
        /*
         * This activity will crash when it is opened.
         */ 

        protected override void OnCreate(Bundle bundle)
        {
            SetContentView(Resource.Layout.activity_testLayout);
        }

        protected override void OnDestroy()
        {
            // Removing the method call to the base class's OnDestroy method will raise an 
            // android.app.SuperNotCalledException.

            //base.OnDestroy();
        }
    }
}