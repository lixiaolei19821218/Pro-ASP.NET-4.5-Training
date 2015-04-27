using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace Handlers
{
    public class Global : System.Web.HttpApplication
    {
        public Global()
        {
            MapRequestHandler += HandleEvent;
            PostMapRequestHandler += HandleEvent;
            PreRequestHandlerExecute += HandleEvent;
            PostRequestHandlerExecute += HandleEvent;
        }
        
        private void HandleEvent(object sender, EventArgs e)
        {
            string eventType = Context.CurrentNotification.ToString();
            if (Context.IsPostNotification)
            {
                eventType = "Post" + eventType;
            }
            System.Diagnostics.Debug.WriteLine("Request Event: {0}",
            new[] { eventType });
        }

        protected void Application_Start(object sender, EventArgs e)
        {

        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}