using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var teacher = new Teacher("Ali", new DateTime(1980, 1, 1), 291873932);
            teacher.getAccount().InsertMoney(100.00f);
            var  student = new Student("mohammad", new DateTime(2000, 1, 1), 92173923);
            var student2 = new Student("ali", new DateTime(2000, 1, 1), 92173924);

            student.CreateBankAccount();
            teacher.getAccount().Pay(50, student.getAccount() );
            Console.WriteLine("Teacher Balance: {0}$",teacher.getAccount().Balance);
            Console.WriteLine("Student Balance: {0}$",student.getAccount().Balance);
            teacher.getAccount().AtmWithdraw(teacher.getAccount().VisaCard);
            Console.WriteLine(teacher.getAccount().Balance);

            

        }
    }
}
