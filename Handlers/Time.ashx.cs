using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Handlers
{
    /// <summary>
    /// Time 的摘要说明
    /// </summary>
    public class Time : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string time = DateTime.Now.ToShortTimeString();
            if (IsAjaxRequest(context.Request))
            {
                context.Response.ContentType = "application/json";
                context.Response.Write(string.Format("{{\"time\": \"{0}\"}}", time));
            }
            else
            {
                context.Response.ContentType = "text/html";
                context.Response.Write(string.Format("<span>{0}</span>", time));
            }
        }

        private bool IsAjaxRequest(HttpRequest request)
        {
            return request.Headers["X-Requested-With"] == "XMLHttpRequest" || request["X-Requested-With"] == "XMLHttpRequest";
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}