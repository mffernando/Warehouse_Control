﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Warehouse.Controllers
{
    public class ReportController : Controller
    {
        // GET: Report
        [Authorize]
        public ActionResult CurrentWarehouse()
        {
            return View();
        }
        // GET: Report
        [Authorize]
        public ActionResult Resupply()
        {
            return View();
        }
    }
}