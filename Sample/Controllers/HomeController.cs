﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sample.Controllers
{
    public class HomeController : PanelController
    {
        // GET: Home
        public ActionResult DashBoard()
        {
            return View();
        }
    }
}