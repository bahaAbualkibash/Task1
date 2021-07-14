using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            // test Accounts and Banking system
            // var teacher = new Teacher("Ali", new DateTime(1980, 1, 1), 291873932);
            // teacher.getAccount().InsertMoney(100.00f);
            // var  student = new Student("mohammad", new DateTime(2000, 1, 1), 92173923);
            // var student2 = new Student("ali", new DateTime(2000, 1, 1), 92173924);
            //
            // student.CreateBankAccount();
            // teacher.getAccount().Pay(50, student.getAccount() );
            // Console.WriteLine("Teacher Balance: {0}$",teacher.getAccount().Balance);
            // Console.WriteLine("Student Balance: {0}$",student.getAccount().Balance);
            // teacher.getAccount().AtmWithdraw(teacher.getAccount().VisaCard);
            // Console.WriteLine(teacher.getAccount().Balance);

            // test Teacher,courses,people and Student classes

            var teacher = new Teacher("John", new DateTime(1980, 1, 1), 8139232);
            var student1 = new Student("ali", new DateTime(2003, 1, 1), 97474347);
            var student2 = new Student("mohammad", new DateTime(2003, 2, 1), 97474348);
            var student3 = new Student("ali", new DateTime(2003, 3, 1), 97474349);
            
            student1.CreateBankAccount();
            student2.CreateBankAccount();
            student3.CreateBankAccount();

            student1.getAccount().InsertMoney(600);
            student2.getAccount().InsertMoney(600);
            student3.getAccount().InsertMoney(600);

            teacher.createCourse();
            student1.ApplyToEnrollInCourse(teacher.GetCourseId());
            student2.ApplyToEnrollInCourse(teacher.GetCourseId());
            student3.ApplyToEnrollInCourse(teacher.GetCourseId());

            teacher.ReserveRoomForSpacificCourse();
            var Rooms = new Rooms(null);
            Rooms.GetReservedRooms();







        }
    }
}
