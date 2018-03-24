using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Warehouse.Models;

namespace Warehouse.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        [AllowAnonymous]
        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult Login(LoginViewModel login, string returnUrl)
        {
            if (!ModelState.IsValid) //if invalid login
            {
                return View(login);
            }

            //test
            var found = (login.User == "UserTest" && login.Password =="12345");

            //cookie authentication
            if (found)
            {
                FormsAuthentication.SetAuthCookie(login.User, login.RemindMe);

                if (Url.IsLocalUrl(returnUrl))
                {
                    return Redirect(returnUrl);
                }
                else
                {
                    RedirectToAction("Index", "Home");
                }
            }
            else
            {
                ModelState.AddModelError("", "Invalid Login, Try Again!");
            }
            return View(login);
        }
    }
}