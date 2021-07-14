using System;
using System.Collections.Generic;

namespace Task1
{
    public class Teacher : Person
    {
        private CurrentAccount account ;
        private int courseId;
        private Courses course;

        public Teacher(string name, DateTime birthdate, int nationalId) : base(name, birthdate, nationalId)
        {
            account = new CurrentAccount(this);
        }

        public Teacher(Info generalInfo) : base(generalInfo)
        {
            account = new CurrentAccount(this);
        }

        public void createCourse()
        {
              course = new Courses(this, genetateCourseId());

        }

        public void deleteStudentFromCourse( int studentId)
        {
            var studentTemp = new Student("", new DateTime(), studentId);
            var course = new Courses(null, this.courseId);
            var targetedCourse = course.FindIfCourseExist(courseId);
            foreach (var student in targetedCourse.GetPersons())
            {
                if (student.GeneralInfo.nationalId == studentTemp.GeneralInfo.nationalId)
                {
                    targetedCourse.GetPersons().Remove(student);
                }
                
            }

        }

        public void ReserveRoomForSpacificCourse()
        {
            var room = new Rooms(course);
            room.reserveRoom(courseId);
        }



        private int genetateCourseId()
        {
            int courseIdLength = 20;
            int courseId = 0;
            var random = new Random();
            for (int i = 0; i < courseIdLength; i++)
            {
                courseId = courseId + random.Next(0, 9);
            }

            return courseId;
        }

        public CurrentAccount getAccount()
        {
            return account;
        }

    }
}