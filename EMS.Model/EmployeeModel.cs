using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using System.Threading.Tasks;


namespace EMS.Model
{
    public class EmployeeModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DOB { get; set; }
        public string IDNumber { get; set; }
        public DateTime DateHired { get; set; }
        //public Nullable<int> RoleID { get; set; }
        //public int RoleId { get; set; }
        public string SelectedRole { get; set; }
        public IEnumerable<SelectListItem> Roles { get; set; }
        //public  RoleModel RoleModel { get; set; }

        ///public virtual Role Role { get; set; }
    }
}
