﻿using System.Web;
using System.Web.Mvc;

namespace Empresa_Electrica_ORM
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
