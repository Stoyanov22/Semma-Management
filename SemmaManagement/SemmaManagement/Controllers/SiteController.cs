using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace SemmaManagement.Controllers
{
    [AllowAnonymous]
    public class SiteController : Controller
    {
        public ActionResult AllowCookies(string ReturnUrl)
        {
            CookieConsent.SetCookieConsent(Response, true);
            return (ReturnUrl == "/") ? RedirectToAction("Index", "Home") : RedirectToAction(ReturnUrl);
        }

        public ActionResult NoCookies(string ReturnUrl)
        {
            CookieConsent.SetCookieConsent(Response, false);
            // if we got an ajax submit, just return 200 OK, else redirect back
            if (Request.IsAjaxRequest())
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.OK);
            }
            else
            {
                return (ReturnUrl == "/") ? RedirectToAction("Index", "Home") : RedirectToAction(ReturnUrl);;
            }
        }


        [OutputCache(Duration = 60 * 60 * 24 * 365, Location = System.Web.UI.OutputCacheLocation.Any)]
        public ActionResult FacebookChannel()
        {
            return View();
        }
    }
}