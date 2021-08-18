using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC8amTigerBatch_09_07_2021.UserControl
{
    public static class MyControl
    {
            public static IHtmlString MyLabel(string content,string color)
            {
                string htmlstring = String.Format("<label style='color:"+color+"'>{0}</label>", content);
                return new HtmlString(htmlstring);
            }
        public static IHtmlString createUrControl(this HtmlHelper helper, string content)
        {
            string htmlstring = "<input type=" + content + ">";
            return new HtmlString(htmlstring);
        }


    }
}