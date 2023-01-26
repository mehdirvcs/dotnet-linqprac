using System.Collections.Generic;

namespace Linqtasks
{
    public class Course
    {
        public int CourseID { get; set; }
        public string CourseName { get; set; }

    }
    public static class Courses 
    {
        public static List<Course> courseList = new List<Course>() {
            new Course() { CourseID = 1, CourseName = "Physics"} ,
            new Course() { CourseID = 2, CourseName = "English" },
            new Course() { CourseID = 3,CourseName = "Urdu"} ,
            new Course() { CourseID = 4, CourseName = "Maths"} ,
            new Course() { CourseID = 5, CourseName = "Science"}
    };
}
}
