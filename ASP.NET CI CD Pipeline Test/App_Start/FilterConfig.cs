﻿using System.Web;
using System.Web.Mvc;

namespace ASP.NET_CI_CD_Pipeline_Test
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
