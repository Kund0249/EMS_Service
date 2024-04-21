using EMS_Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EMS_Service.Controllers
{
    public class EmployeeController : ApiController
    {
        private readonly EmployeeRepository repository;
        public EmployeeController()
        {
            repository = new EmployeeRepository();
        }
        public List<EmployeeModel> GetEmployee(int id)
        {
            return repository.GetEmployees().Where(x => x.EmpId == id).ToList();
            //return "Hello from API Controller";
        }
    }
}
