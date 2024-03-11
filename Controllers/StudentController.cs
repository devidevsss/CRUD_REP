using CRUD_REP.Data;
using CRUD_REP.IService;
using CRUD_REP.Model;
using CRUD_REP.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_REP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private IStudentService _studentService ;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        //Get all employees in db
        [HttpGet]
        public IActionResult GetAllStudents() 
        { 
            var student = _studentService.GetAllStudents();
            if (student == null)
            {
                return NotFound("Student not found.");
            }
            return Ok(student);
        }

        //Get specific employee based on id
        [HttpGet("{id}")]
        public IActionResult GetStudentById(int id)
        {
            var student =  _studentService.GetStudentById(id);
            if(student == null)
            {
                return NotFound("Student not found.");
            }
            return Ok(student);
        }

        //Add 
        [HttpPost]
        public IActionResult AddStudent(string name, string course)
        {
            var newStudent = _studentService.AddStudent(name, course);
            if (newStudent == null)
            {
                return NotFound("Student info not added.");
            }
            return Ok(newStudent);
        }

        [HttpPut]
        public IActionResult UpdateStudents(int id, string name, string course)
        {
            var student = _studentService.UpdateStudents(id, name, course);
            if (student == null)
            {
                return NotFound("Student info not updated.");
            }
            return Ok(student);
        }

        [HttpDelete]

        public IActionResult DeleteStudent(int id)
        {
            var student =  _studentService.DeleteStudent(id);
            if (student == null)
            {
                return NotFound("Student info not deleted.");
            }
            return Ok(student);
        }
    }
}
