using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Warehouse.Controllers
{
    public class ReportController : Controller
    {
        // GET: Report
        public ActionResult CurrentWarehouse()
        {
            return View();
        }
        // GET: Report
        public ActionResult Resupply()
        {
            return View();
        }
    }
}