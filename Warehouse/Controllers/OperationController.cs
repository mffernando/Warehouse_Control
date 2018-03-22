using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Warehouse.Controllers
{
    public class OperationController : Controller
    {
        // GET: Operation
        [Authorize]
        public ActionResult ProductInput()
        {
            return View();
        }
        // GET: Operation
        [Authorize]
        public ActionResult ProductOutput()
        {
            return View();
        }
        // GET: Operation
        [Authorize]
        public ActionResult ProductLoss()
        {
            return View();
        }
        // GET: Operation
        [Authorize]
        public ActionResult Inventory()
        {
            return View();
        }
    }
}