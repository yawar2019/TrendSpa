﻿using System.Web;
using System.Web.Mvc;

namespace ADO_DotNetExample
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
