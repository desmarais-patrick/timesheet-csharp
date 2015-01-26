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
        public string /*ActionResult*/ Index()
        {
            return "This is my default response!"; // View();
        }
    }
}