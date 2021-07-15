using System;
using System.Collections.Generic;

namespace Task1
{
    public class Teacher : Person
    {
        private CurrentAccount account ;
        private int courseId;
        private Courses course;
        private Rooms courseRoom;
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
             courseId = genetateCourseId();
              course = new Courses(this, courseId);
              course.createCourse(courseId,this);

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

        public Rooms ReserveRoomForSpacificCourse()
        {
            var room = new Rooms(course);
            room = room.reserveRoom(courseId);
            courseRoom = room;
            return courseRoom;
        }

      

        private int genetateCourseId()
        {
            int courseIdLength = 20;
            int courseId = 0;
            var random = new Random();
            for (int i = 0; i < courseIdLength; i++)
            {
                courseId = courseId + random.Next(0, 9999);
            }

            return courseId;
        }

        public CurrentAccount getAccount()
        {
            return account;
        }

        public int GetCourseId()
        {
            return courseId;
        }

        public Rooms GetCourseRoom()
        {
            return courseRoom;
        }
    }
}