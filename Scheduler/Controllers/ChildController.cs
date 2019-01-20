using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Entities;

namespace Scheduler.Controllers
{
    public class ChildController : Controller
    {
        protected SchedulerEntities db = new SchedulerEntities();
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