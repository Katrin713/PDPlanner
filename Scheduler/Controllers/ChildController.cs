using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Scheduler.Controllers
{
    public class ChildController : Controller
    {
        // GET: Child
        public ActionResult Workplace()
        {
            return View();
        }

        public ActionResult MainInformation()
        {
            return PartialView();
        }

        public ActionResult Tasks()
        {
            return PartialView();
        }

        public ActionResult AllDay()
        {
            return PartialView();
        }
    }
}