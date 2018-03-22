using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Warehouse.Controllers
{
    public class GraphicController : Controller
    {
        // GET: Graphic
        [Authorize]
        public ActionResult MonthLoss()
        {
            return View();
        }
        // GET: Graphic
        [Authorize]
        public ActionResult CheckInCheckOut()
        {
            return View();
        }
    }
}