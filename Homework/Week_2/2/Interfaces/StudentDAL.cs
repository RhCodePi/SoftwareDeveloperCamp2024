using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class StudentDAL : IStudentDAL
    {
        private List<Student> students = new List<Student>();

        public StudentDAL()
        {

            Student student = new Student()
            {
                Id = 1,
                Name = "Abdullah",
                Surname = "Vural",
                Number = "1215648320"
            };


            Student student2 = new Student()
            {
                Id = 2,
                Name = "Hasan",
                Surname = "Basri",
                Number = "1345846870"

            };

            Student student3 = new Student()
            {
                Id = 3,
                Name = "Yavuz Sultan",
                Surname = "Selim",
                Number = "1202185680",
            };


            students.AddRange(new List<Student>() { student, student2, student3});
        }
        public Student GetStudent(string name)
        {
            return students.FirstOrDefault(x => x.Name == name);
        }

        public List<Student> GetStudents()
        {
            return students;
        }
    }
}
