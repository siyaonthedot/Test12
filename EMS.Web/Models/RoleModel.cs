using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace EMS.Web.Models
{
    public class RoleModel
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public Nullable<int> RateID { get; set; }
        public string SelectedRate { get; set; }
        [Display(Name = "Rates:")]
        public IEnumerable<SelectListItem> Rates { get; set; }
    }
}
