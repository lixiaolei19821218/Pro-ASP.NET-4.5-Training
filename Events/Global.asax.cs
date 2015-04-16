using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace Events
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {            
            EventCollection.Add(EventSource.Application, "Start");
            Application["message"] = "Application Events";
        }

        protected void Application_End(object sender, EventArgs e)
        {
            EventCollection.Add(EventSource.Application, "End");            
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            string[] langs = ((HttpApplication)sender).Request.UserLanguages;
            if (langs != null && langs.Length > 0 && langs[0] != null)
            {
                try
                {
                    Thread.CurrentThread.CurrentCulture = new CultureInfo(langs[0]);

                    Thread.CurrentThread.CurrentCulture = new CultureInfo("en-GB");
                }
                catch { }
            }
        }
        
        public void AverageTime_NewAverage(object src, AverageTimeEventArgs args)
        {
            Response.Write(string.Format("<h3>Ave time: {0:F2}ms</h3>",
            args.AverageTime));
        }
    }
}