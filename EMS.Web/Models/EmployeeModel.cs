using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EMS.Web.Models
{
    public class EmployeeModel
    {

        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DOB { get; set; }
        public string IDNumber { get; set; }
        public string DateHired { get; set; }
        public string SelectedRole { get; set; }
        public IEnumerable<SelectListItem> Roles { get; set; }

    }
}