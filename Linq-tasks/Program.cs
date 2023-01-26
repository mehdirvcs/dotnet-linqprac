using System;
using System.Collections.Generic;
using System.Linq;


namespace Linqtasks
{
    public class Program
	{
        private static string coursename;

        public static void Main()
        {
            // Declaration
            List<Student> students = stds.StudentList;
            List<Course> courses = Courses.courseList;
            List<StudentCourse> studentcourses = SC.SCList;
            List<StudentMark> StudentMarks = Marks.MarksList;
 
            //Task 1
            Console.WriteLine("Task 1 : use students and Courses " +
                "-Show Student ID and Courses ID populate data as per in 'studentCourses'");
            Console.WriteLine();
            
            foreach (var obj in studentcourses)
            {

                Console.WriteLine("Student ID: {0} - CourseID: {1}", obj.StudentID, obj.CourseID);
               
            }
            Console.WriteLine();


            //Task 2
            Console.WriteLine("Task 2 : use studentCourses, students, Courses " +
                "-Show Student Name and Courses Name");
            Console.WriteLine();

            var studentcourseDetails1 = (from sc in studentcourses
                                    join s in students on sc.StudentID equals s.StudentID
                                    join c in courses on sc.CourseID equals c.CourseID
                                    select new StudentCourseDetail { courseid = c.CourseID, coursename = c.CourseName, studentid = s.StudentID, studentname = s.StudentName }).ToList();

            foreach (var obj in studentcourseDetails1)
            {

                Console.WriteLine("Student ID: {0} - CourseID: {1} CourseName: {2}  StudentName: {3} ", obj.studentid, obj.courseid, obj.coursename, obj.studentname);
            }
            Console.WriteLine();

            //Task 3
            Console.WriteLine("Task 3 : use studentCourses2, students, Courses " +
                "-Show Student Name and Courses Name but Show All Students present in 'students'");
            Console.WriteLine(" ");


            var studentcourseDetails2 = (from s in students
                                     join sc in studentcourses on s.StudentID equals sc.StudentID 
                                     select new { sc.StudentID, s.StudentName, sc.CourseID } into intermediate
                                     join c in courses on intermediate.CourseID equals c.CourseID into StudentInfo
                                     from details in StudentInfo.DefaultIfEmpty()
                                         select (courseid: intermediate.CourseID, coursename = details?.CourseName ?? string.Empty, studentid: intermediate.StudentID, studentname: intermediate.StudentName)).ToList();
            foreach (var obj in studentcourseDetails2)
            {
                Console.WriteLine("Student Name: {1} - Course Name: {0}", obj.Item2, obj.studentname);
            }
            Console.WriteLine();

            // Task 6
            Console.WriteLine("Task 6 : Get Students Marks of given " +
                "(DateTime,Courses ID and Student ID)");
            Console.WriteLine();

            Console.WriteLine("Enter StudentID: ");
            int StudentID1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter CourseID: ");
            int CourseID1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Date DD/MM/YYYY : ");
            string date = (Console.ReadLine());
            
            if (StudentMarks.Any(n => n.StudentID == StudentID1 && n.DateTimes == date && n.CourseID == CourseID1))
            {
                var SMarks = from sm in StudentMarks
                             where sm.DateTimes == date
                             where sm.StudentID == StudentID1
                             where sm.CourseID == CourseID1
                             select sm;
                foreach (StudentMark std in SMarks)
                {
                    Console.WriteLine($"CourseID: {std.CourseID} Student Marks: {std.Marks} ");
                }
            }
            else
            {
                Console.WriteLine("No Record exist");
            }
            Console.WriteLine();
            
            Console.WriteLine("Task 7 : Total Marks of students in given " +
                "(DateTime and Student ID ) Return: Decimal ");
            Console.WriteLine();

            Console.WriteLine("Enter StudentID: ");
             StudentID1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Date DD/MM/YYYY : ");
             string date1 = (Console.ReadLine());

            if (StudentMarks.Any(n => n.StudentID == StudentID1 && n.DateTimes == date1))
            {
                decimal sumOf = StudentMarks.Where(s => s.StudentID == StudentID1 && s.DateTimes == date1).Sum(s => s.Marks);
                Console.WriteLine("Total Marks of student {0}: {1}", StudentID1, sumOf);

            }
            else
            {
                Console.WriteLine("No Records");
            }
            Console.WriteLine();


            // Task 8
            Console.WriteLine("Task 8: Student who get maximum Marks on " +
                "given(DateTime) Return: Student Class(ID, Marks) ");
            Console.WriteLine();

            Console.WriteLine("Enter Date DD/MM/YYYY : ");
             string date2 = Console.ReadLine();


            if (StudentMarks.Any(n => n.DateTimes == date2))
            {
                decimal MaxMarks = StudentMarks.Where(s => s.DateTimes == date2).Max(s => s.Marks);
                var stddetails = (from sd in StudentMarks
                                  join s in students on sd.StudentId equals s.StudentId
                                  where sd.Marks == MaxMarks
                                  select new { stdname = s.StudentName, marks = MaxMarks });
                foreach (var w in stddetails) {
                    Console.WriteLine("Max Marks on given date are: {0} of student {1}", w.marks, w.stdname);
                }
            }
            else
            {
                Console.WriteLine("No Records");
            }
            Console.WriteLine();

            // Task 9
            Console.WriteLine("Task 9: Students who get Marks in between " +
                "range (70 - 100)Marks Return List<StudentsMarks> ");
            Console.WriteLine();

            var Slist = (from sm in StudentMarks
                         join s in students on sm.StudentID equals s.StudentID 
                        where sm.Marks >= 70 && sm.Marks <= 100
                        select new {ID= s.StudentID, Marks = sm.Marks, Name=s.StudentName }).ToList();
            foreach (var std in Slist)
            {
                Console.WriteLine("Student ID: {0} StudentMarks: {1} StudentName: {2} ", std.ID, std.Marks,std.Name);
            }
        }
    }
}


