using System;
using System.Collections.Generic;
using System.Linq;

namespace Task1
{
    public class Courses
    {
        private readonly List<Courses> _courses = new List<Courses>();
        private List<Person> _persons = new List<Person>();
        private double coursePrice = 100.00f;
        private Teacher courseTeacher;
        private int courseId { get; set; }

        public Courses(Teacher courseTeacher,int courseId)
        {
            this.courseId = courseId;
            this.courseTeacher = courseTeacher;
        }


        private int getCourseId()
        {
            return courseId;
        }
        public void AddStudents(Student student,int courseId)
        {
            if (student == null) return;
            if (student.account.Balance > coursePrice)
            {
                student.account.Pay(coursePrice,courseTeacher.account);
                var course =FindIfCourseExist(_courses,courseId);
                if (course == null)
                {
                    Console.WriteLine("Course does not exist");
                }
                course._persons.Add(student);
                Console.WriteLine("{0}  enroll in this course", student.GeneralInfo.name);

            }
            else
            {
                Console.WriteLine("{0} don't have Enough money to enroll in this course",student.GeneralInfo.name);
            }

        }

        private Courses FindIfCourseExist(List<Courses> courses, int courseId)
        {
            for (var i = 0; i < _courses.Count; i++)
            {
                if (courses.ElementAt(i).getCourseId() == courseId)
                {
                    return this;
                }
            }

            return null;
        }
        private Courses FindIfCourseExist( int courseId)
        {
           var course =  FindIfCourseExist(_courses, courseId);
           if (course != null)
           {
               return course;
           }

           return null;
        }

        public Courses getCourse(int courseId)
        {
            var course = FindIfCourseExist(courseId);
            if (course == null)
            {
               return null;
            }
            return course;
           

        }

        public Teacher GeTeacher()
        {
            return courseTeacher;
        }

    }
}