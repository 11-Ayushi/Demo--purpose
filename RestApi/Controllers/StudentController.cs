using Microsoft.AspNetCore.Mvc;
using RestApi.Interface;
using RestApi.Model;
using RestApi.Services;
using System.Collections.Generic;

namespace RestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : Controller
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet()]
        public List<Student> GetAllStudents()
        {
            return _studentService.GetAll();
        }

        [HttpPost]
        public Student AddStudents(Student student)
        {
            return _studentService.AddStudent(student);
        }

        [HttpGet("/id")]
        public Student getById(int id)
        {
            return _studentService.GetStudentById(id);
        }


    }
}
