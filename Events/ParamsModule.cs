using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Events
{
    public class ParamsModule : IHttpModule
    {
        public void Init(HttpApplication app)
        {
            app.PostAuthenticateRequest += delegate(object src, EventArgs args)
            {               
                if (app.Request.Url.LocalPath == "/Params.aspx" && !app.User.Identity.IsAuthenticated)
                {
                    app.Context.AddError(new UnauthorizedAccessException());
                }
            };
        }

        public void Dispose()
        {
        }
        
        public void OnLogRequest(Object source, EventArgs e)
        {
        }


    }
}