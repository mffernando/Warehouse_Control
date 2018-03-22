using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Warehouse.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration
        [Authorize]
        public ActionResult ProductGroup()
        {
            return View();
        }
        // GET: Registration
        [Authorize]
        public ActionResult ProductBrand()
        {
            return View();
        }
        // GET: Registration
        [Authorize]
        public ActionResult Warehouse()
        {
            return View();
        }
        // GET: Registration
        [Authorize]
        public ActionResult MeasureUnit()
        {
            return View();
        }
        // GET: Registration
        [Authorize]
        public ActionResult Product()
        {
            return View();
        }
        // GET: Registration
        [Authorize]
        public ActionResult Country()
        {
            return View();
        }
        // GET: Registration
        [Authorize]
        public ActionResult State()
        {
            return View();
        }
        // GET: Registration
        [Authorize]
        public ActionResult City()
        {
            return View();
        }
        // GET: Registration
        [Authorize]
        public ActionResult Provider()
        {
            return View();
        }
        // GET: Registration
        [Authorize]
        public ActionResult UserProfile()
        {
            return View();
        }
        // GET: Registration
        [Authorize]
        public ActionResult User()
        {
            return View();
        }
    }
}