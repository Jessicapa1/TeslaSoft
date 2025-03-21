﻿using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using TeslaSoft.Controllers;

namespace TeslaSoft.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : TeslaSoftControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
