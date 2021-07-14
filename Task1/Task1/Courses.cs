using System;
using System.Collections.Generic;
using System.Linq;

namespace Task1
{
    public class Courses
    {
        private static readonly List<Courses> _courses = new List<Courses>();
        private List<Person> _persons = new List<Person>();
        private double coursePrice = 100.00f;
        private Teacher courseTeacher;
        private int courseId { get; set; }

        public Courses(Teacher courseTeacher, int courseId)
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
            var targetedCourse = FindIfCourseExist(courseId);
            if (student.getAccount().Balance > coursePrice)
            {
                student.getAccount().Pay(coursePrice,targetedCourse.courseTeacher.getAccount());
                var course =FindIfCourseExist(_courses,courseId);
                if (course == null)
                {
                    Console.WriteLine("Course does not exist");
                }
                course._persons.Add(student);
                Console.WriteLine($"{student.GeneralInfo.name}   enroll in this course");

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
                    return courses.ElementAt(i);
                }
            }

            return null;
        }
        public Courses FindIfCourseExist( int courseId)
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
        public void SetTeacher(Teacher teacher)
        {
            courseTeacher = teacher;
        }
        public Teacher GeTeacher()
        {
            return courseTeacher;
        }

        public List<Person> GetPersons()
        {
            return _persons;
        }

        public bool FindIfStudentAlreadyExists(Student student,int courseId)
        {
            foreach (var person in _persons)        {
                if (person.GeneralInfo.nationalId == student.GeneralInfo.nationalId)
                {
                    return true;
                }
            }

            return false;

        }

        public void createCourse(int courseId, Teacher teacher)
        {
            for (int i = 0; i < _courses.Count; i++)
            {
                
                    if (_courses[i].getCourseId() == courseId)
                    {
                        Console.WriteLine("Course {0} already exist",courseId);
                       
                        return;
                    }
                
          }

            this.courseTeacher = teacher;
            
            _courses.Add(this);
        }
    }

}