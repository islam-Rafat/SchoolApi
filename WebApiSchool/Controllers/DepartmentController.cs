using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WebApiSchool.Models;

namespace WebApiSchool.Controllers
{
    public class DepartmentController : ApiController
    {
        private schoolApiEntities db = new schoolApiEntities();

        // GET: api/Department
        public IQueryable<Department> GetDepartment()
        {
            return db.Department;
        }
        //GET: api/Department/5
        [ResponseType(typeof(Student))]
        public IHttpActionResult GetStudent(int id)
        {
            List<Student> student = db.Student.Where(std => std.DepartmentId == id).ToList();
            if (student == null)
            {
                return NotFound();
            }

            return Ok(student);
        }



    }
}