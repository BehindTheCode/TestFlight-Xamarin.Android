using System;

namespace Com.TestFlightApp.Lib
{
    public partial class TestFlight
    {
        /// <summary>
        /// Create an entry in the TestFlight crash log.
        /// </summary>
        /// <param name="stackTrace">A string to write to the log. At minimum it should include the error message and stack trace.</param>
        /// <param name="threadName">The name of the thread that raised the exception.</param>
        public static void SendCrash(string stackTrace, string threadName)
        {
            SendCrash(Java.Lang.JavaSystem.CurrentTimeMillis(), stackTrace, threadName);
        }

        /// <summary>
        /// Create an entry in the TestFlight crash log. This method should be called from the thread that raised the exception.
        /// </summary>
        /// <param name="stackTrace">A string to write to the log. At minimum it should include the error message and stack trace.</param>
        public static void SendCrash(string stackTrace)
        {
            SendCrash(stackTrace, Java.Lang.Thread.CurrentThread().Name);
        }

        /// <summary>
        /// Create an entry in the TestFlight crash log. This method should be called from the thread that raised the exception.
        /// </summary>
        /// <param name="e">The Exception to log.</param>
        public static void SendCrash(Exception e)
        {
            SendCrash(e.ToString());
        }
    }
}