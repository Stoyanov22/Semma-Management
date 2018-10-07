using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SemmaManagement.Controllers
{
    public class ServicesController : Controller
    {
        // GET: Services
        public ActionResult Index()
        {
            return View();
        }

        // GET: Services
        public ActionResult Agronomy()
        {
            return View();
        }

        // GET: Services
        public ActionResult Consultancy()
        {
            return View();
        }

        // GET: Services
        public ActionResult Outsourcing()
        {
            return View();
        }
    }
}