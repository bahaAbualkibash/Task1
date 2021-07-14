
using System;

namespace Task1
{
    public class Student : Person
    {

        private SavingsAccount account;
        public Student(string name, DateTime birthdate, int nationalId) : base(name, birthdate, nationalId) {}

        public Student(Info generalInfo) : base(generalInfo){}
        public void CreateBankAccount()
        {
            account = new SavingsAccount(this);
        }

        public SavingsAccount getAccount()
        {
            return account;
        }

        public void ApplyToEnrollInCourse(int courseId)
        {
            var course = new Courses(null,courseId);
            course.AddStudents(this,courseId);

        }




    }
}