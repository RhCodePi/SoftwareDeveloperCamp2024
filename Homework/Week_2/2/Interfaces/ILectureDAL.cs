using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface ILectureDAL
    {
        Lecture GetLecture(string name);
        List<Lecture> GetLectures();
    }
}
