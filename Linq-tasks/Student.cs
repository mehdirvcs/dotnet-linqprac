using System.Collections.Generic;

namespace Linqtasks
{
    public class Student
    {
        public int StudentID { get; set; }
        public object StudentId { get; internal set; }
        public string StudentName { get; set; }
    }

    public static class stds
    {
        public static List<Student> StudentList = new List<Student>() {
    new Student() { StudentID = 1, StudentName = "John"} ,
    new Student() { StudentID = 2, StudentName = "Edward" } ,
    new Student() { StudentID = 3,StudentName = "Bill" } ,
    new Student() { StudentID = 4, StudentName = "Jerry"} ,
    new Student() { StudentID = 5, StudentName = "Brian" }
};
    }
}
