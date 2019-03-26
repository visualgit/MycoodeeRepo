using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EmpDataAccesss;
using Newtonsoft.Json.Serialization;


namespace EmpService.Controllers
{
    public class EmployeesController : ApiController
    {
        private object config;

        public IEnumerable<Employee> Get()
        {
            using (EmployeeDBEntities entities = new EmployeeDBEntities())
            {

                return entities.Employees.ToList();
            }
        }


        public IEnumerable<Employee> Get(int id)
        {
            using (EmployeeDBEntities entities = new EmployeeDBEntities())
            {
                yield return entities.Employees.FirstOrDefault(e => e.ID == id);
            }
        }
    }
}

