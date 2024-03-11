using CRUD_REP.Data;
using CRUD_REP.IService;
using CRUD_REP.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CRUD_REP.Service
{
    public class StudentService : IStudentService
    {

        private readonly StudentDbContext _dbContext;

        public StudentService(StudentDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IEnumerable<Student> GetAllStudents()
        {
            var students = _dbContext.Students.ToList();

            return students;
        }
        public Student GetStudentById(int id)
        {
            var student = _dbContext.Students.FirstOrDefault(x => x.Id == id);

            return student;
        }
        public string AddStudent(string name, string course)
        {
            var newStudent = new Student
            {
                Name = name,
                Course = course
            };

            _dbContext.Students.Add(newStudent);
            _dbContext.SaveChanges();

            return name + " is added.";
        }
        public string UpdateStudents(int id, string name, string course)
        {
            var student = _dbContext.Students.FirstOrDefault(x => x.Id == id);

            if (student != null)
            {
                student.Name = name;
                student.Course = course;

                _dbContext.SaveChanges();
                return name + " is updated.";
            }

            return null;
        }
        public Student DeleteStudent(int id)
        {
            var employee = _dbContext.Students.FirstOrDefault(x => x.Id == id);

            if (employee != null)
            {
                _dbContext.Remove(employee);
                _dbContext.SaveChanges();
                return employee;
            }

            return null;
        }

    }
}
