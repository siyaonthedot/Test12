using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using EMS.Model;

namespace EMS.Model
{
    public  class RoleModel
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public Nullable<int> RateID { get; set; }
        public string SelectedRate { get; set; }
        public RateModel Rate { get; set; }
    }
}
