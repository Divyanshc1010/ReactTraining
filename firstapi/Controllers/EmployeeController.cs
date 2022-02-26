using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using firstapi.Models;
using Microsoft.EntityFrameworkCore;


namespace firstapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        [Route("AllEmps")]

        public async Task<ActionResult<List<Employee>>> getAllEmployess()
        {
            using(var db=new DatabaseTrainingContext())
            {
                var emps=await db.Employees.ToListAsync();
                return Ok(emps);
            }
        }

        [HttpGet]
        [Route("EmpById/{id}")]
         public async Task<ActionResult<List<Employee>>> getEmpById(int id)
        {
            using(var db=new DatabaseTrainingContext())
            {
                Employee obj=await db.Employees.FindAsync(id);
                return Ok(obj);
            }
        }

        [HttpPost]
        [Route("AddEmp")]
        
        public async Task<ActionResult> AddEmployess(Employee e)
        {
            using(var db=new DatabaseTrainingContext())
            {
                db.Employees.Add(e);
                await db.SaveChangesAsync();
                return Ok();
            }
        }

        [HttpPut]
        [Route("EditEmp")]
        public async Task<ActionResult> ModifyEmployees(int id,Employee e)
        {
            using(var db=new DatabaseTrainingContext())
            {
                db.Employees.Update(e);
                await db.SaveChangesAsync();
                return Ok();
            }
        }

        [HttpDelete]
        [Route("DeleteEmp")]
        public async Task<ActionResult> RemoveEmp(int id)
        {
            using(var db=new DatabaseTrainingContext())
            {
                Employee e=db.Employees.Find(id);
                db.Employees.Remove(e);
                await db.SaveChangesAsync();
                return Ok();
            }
        }
        
    }
}