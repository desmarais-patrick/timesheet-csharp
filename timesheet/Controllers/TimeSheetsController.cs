using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace timesheet.Controllers
{
    public class TimeSheetsController : Controller
    {
        // GET: TimeSheet
        public string /*ActionResult*/ Index(string sortOrder = "ASC", int range = 20)
        {
            return HttpUtility.HtmlEncode("Timesheets ordered " + sortOrder + " in batch of " + range); // View();
        }
    }
}