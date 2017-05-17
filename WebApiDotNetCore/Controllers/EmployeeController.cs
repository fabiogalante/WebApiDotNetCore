using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiDotNetCore.Models;

namespace WebApiDotNetCore.Controllers
{
    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {

        private readonly NorthwindDbContext _db;

        public EmployeeController(NorthwindDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public List<Employee> Get()
        {
            return _db.Employees.ToList();
        }

        [HttpGet("{id}")]
        public Employee Get(int id)
        {
            return _db.Employees.Find(id);
        }

        [HttpPost]
        public IActionResult Post([FromBody]Employee obj)
        {
            _db.Employees.Add(obj);
            _db.SaveChanges();
            return new ObjectResult("Colaborador adicionado com sucesso!");

        }




        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]Employee obj)
        {
            _db.Entry(obj).State = EntityState.Modified;
            _db.SaveChanges();
            return new ObjectResult("Colaborador alterado com sucesso!");
        }




        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _db.Employees.Remove(_db.Employees.Find(id));
            _db.SaveChanges();
            return new ObjectResult("Colaborador excluido com sucesso!");
        }
    }
}
