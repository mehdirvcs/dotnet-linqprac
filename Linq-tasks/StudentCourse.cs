using System.Collections.Generic;

namespace Linqtasks
{
    public class StudentCourse
    {
        public int CourseID { get; set; }
        public int StudentID { get; set; }

    }
    public static class SC
    {
        public static List<StudentCourse> SCList = new List<StudentCourse>()
        {
            new StudentCourse() {StudentID=1,CourseID=1},
            new StudentCourse() {StudentID=1,CourseID=3},
            new StudentCourse() {StudentID=2,CourseID=4},
            new StudentCourse() {StudentID=2,CourseID=5},
            new StudentCourse() {StudentID=2,CourseID=2},
            new StudentCourse() {StudentID=3,CourseID=4},
            new StudentCourse() {StudentID=3,CourseID=1},
            new StudentCourse() {StudentID=3,CourseID=5},
            new StudentCourse() {StudentID=5,CourseID=1},
            new StudentCourse() {StudentID=5,CourseID=2},
            new StudentCourse() {StudentID=5,CourseID=3},
            new StudentCourse() {StudentID=5,CourseID=4},
            new StudentCourse() {StudentID=4,CourseID=0},
            new StudentCourse() {StudentID=5,CourseID=5}

                                };
    }
}
