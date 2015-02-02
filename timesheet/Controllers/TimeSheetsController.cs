using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace timesheet.Controllers
{
    public class TimeSheetsController : Controller
    {
        int ASCENDING_ORDER = 0;
        int DESCENDING_ORDER = 1;

        // GET: TimeSheet
        public string /*ActionResult*/ Index(string sortOrder, int fromIndex = 0, int range = 20)
        {
            int order = (sortOrder == "ASC" ? ASCENDING_ORDER : DESCENDING_ORDER);
            return HttpUtility.HtmlEncode("Timesheets order (" + order + ") in batch of " + range + " from index " + fromIndex); // View();
        }
    }
}