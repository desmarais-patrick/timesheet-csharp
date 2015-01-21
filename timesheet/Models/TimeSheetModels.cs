using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace timesheet.Models
{
    public class TimeSheet
    {
        [Required(ErrorMessage = "La date est requise.")]
        [DataType(DataType.Date)]
        [DisplayName("Date")]
        public DateTime Date { get; set; }

        [Range(0.0, 24.0, ErrorMessage = "La temps de travail doit se situer entre 0 et 24 heures.")]
        [DataType(DataType.Text)]
        [DisplayName("Temps de travail")]
        public double HoursWorked { get; set; }
    }

    public class TimeSheetCollection : List<TimeSheet>
    {
        
    }
}
