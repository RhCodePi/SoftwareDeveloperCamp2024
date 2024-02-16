using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class LectureDAL : ILectureDAL
    {
        private List<Lecture> lectures= new List<Lecture>();

        public LectureDAL() {

            Lecture lecture = new Lecture()
            {
                Id = 1,
                Name = "C#",
                Description = "YOU WILL LEARN C#",
                LectureCode = "BIL2042"
            };


            Lecture lecture2 = new Lecture()
            {
                Id = 2,
                Name = "Java",
                Description = "YOU WILL LEARN JAVA",
                LectureCode = "BIL2242"

            };

            Lecture lecture3 = new Lecture()
            {
                Id = 3,
                Name = "Theory of Computation & Automata Theory",
                Description = " It is a branch in theoretical Computer Science that deals with " +
                "whether problems can be solved and how efficiently  " +
                "problems can be solved on a model of computation, using an algorithm. ",
                LectureCode = "1202185680",
            };
            lectures.AddRange(new List<Lecture>() { lecture, lecture2, lecture3});
        }


        public Lecture GetLecture(string name)
        {
            return lectures.FirstOrDefault(x => x.Name == name);
        }

        public List<Lecture> GetLectures()
        {
            return lectures;
        }
    }
}
