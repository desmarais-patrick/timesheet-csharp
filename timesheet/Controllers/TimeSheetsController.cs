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
            return HttpUtility.HtmlEncode("Time sheets ordered by " + order + " (0 ascending, 1 descending) in batch of " + range + " entries, starting from index " + fromIndex); // View();
        }

        public string Detail(int ID = 1)
        {
            return HttpUtility.HtmlEncode("Time sheet #" + ID);
        }
    }
}