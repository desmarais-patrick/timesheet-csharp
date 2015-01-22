using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using timesheet.Models;

namespace timesheet.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // Fake timesheets for now...
            var timesheets = new TimeSheetCollection();

            var ts1 = new TimeSheet();
            ts1.Date = new System.DateTime(2014, 1, 21);
            ts1.WorkSubject = "Mise en place du projet, versionnement sur Git, stylisation avec Bootstrap";
            ts1.HoursWorked = 5.25;
            timesheets.Add(ts1);

            var ts2 = new TimeSheet();
            ts2.Date = new System.DateTime(2014, 1, 22);
            ts2.WorkSubject = "Déploiement sur Azure, migration à VS2013";
            ts2.HoursWorked = 6.50;
            timesheets.Add(ts2);

            return View(timesheets);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}