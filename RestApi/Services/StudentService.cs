using RestApi.Interface;
using RestApi.Model;
using System.Collections.Generic;

namespace RestApi.Services
{
    public class StudentService : IStudentService
    {

        List<Student> students;

        public StudentService()
        {
            students = new List<Student>();
            students.Add(new Student(1, "Ayushi", 22));
            students.Add(new Student(2, "Akriti", 26));

        }

        public List<Student> GetAll()
        {
            return students;
        }

        public Student AddStudent(Student student)
        {
            students.Add(student);

            return student;
        }

        public Student GetStudentById(int id)
        {
            
            Student s = null;
            foreach(Student student in students)
            {
                if(student.Id == id)
                {
                    s = student;
                    break;
                }
            }
            return s;
        }
    }
}
