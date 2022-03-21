using RestApi.Model;
using System.Collections.Generic;

namespace RestApi.Interface
{
    public interface IStudentService
    {
        public List<Student> GetAll();

        public Student AddStudent(Student student);

        public Student GetStudentById(int id);
    }
}
