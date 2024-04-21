using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EMS_Service.Models
{
    public class EmployeeRepository
    {
        public List<EmployeeModel> GetEmployees()
        {
            return new List<EmployeeModel>()
            {
                new EmployeeModel(){EmpId = 1,Name="A"},
                new EmployeeModel(){EmpId = 2,Name="B"},
                new EmployeeModel(){EmpId = 3,Name="C"},
            };
        }
    }
}