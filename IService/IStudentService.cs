using CRUD_REP.Model;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_REP.IService
{
    public interface IStudentService
    {
        public IEnumerable<Student> GetAllStudents();
        public Student GetStudentById(int id);
        public string AddStudent(string name, string course);
        public string UpdateStudents(int id, string name, string course);
        public Student DeleteStudent(int id);
    }
}
