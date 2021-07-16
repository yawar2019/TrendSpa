using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC8amTigerBatch_09_07_2021.Models
{
    public class EmpDept
    {
        public List<EmployeeModel> Emp { get; set; }
        public List<DepartmentModel> Dept { get; set; }
    }
}