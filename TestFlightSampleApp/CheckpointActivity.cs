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
using Com.TestFlightApp.Lib;

namespace TestFlightSampleApp
{
    [Activity(Label = "Checkpoint Activity")]
    public class CheckpointActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.activity_checkpoint);

            // Write the checkpoint to Test Flight.
            TestFlight.PassCheckpoint("User started checkpoint activity.");
        }
    }
}