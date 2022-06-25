using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using s22680.Shared.Models;
using System.Collections.Generic;

namespace s22680.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private static List<Student> _students = new List<Student>();

        public StudentsController()
        {
            _students.Add(new Student
            {
                IdStudent = 1,
                FirstName="John",
                LastName="Malewski"

            });

            _students.Add(new Student
            {
                IdStudent = 2,
                FirstName = "Test",
                LastName = "Testowy"

            });
            

        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_students);

        }

    }
}
