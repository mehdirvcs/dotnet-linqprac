using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linqtasks
{
    public class StudentMark
    {
        public int StudentID { get; set; }
        public object StudentId { get; internal set; }
        public int CourseID { get; set; }
        public string DateTimes { get; set; }
        public decimal Marks { get; set; }

    }

    public static class Marks 
    {
        public static List<StudentMark> MarksList = new List<StudentMark>()
        {
            new StudentMark() { StudentID = 1,CourseID = 1, Marks = 60,DateTimes = "7/04/2016"} ,
            new StudentMark() { StudentID = 2,CourseID = 2, Marks = 90,DateTimes = "1/02/2016"  } ,
            new StudentMark() { StudentID = 3,CourseID = 3, Marks = 87,DateTimes = "3/03/2016" } ,
            new StudentMark() { StudentID = 4, CourseID = 4, Marks = 50,DateTimes = "5/06/2016"} ,
            new StudentMark() { StudentID = 1, CourseID = 5, Marks = 76,DateTimes = "7/04/2016" }
        };
}
}
