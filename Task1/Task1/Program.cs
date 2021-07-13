using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var teacher = new Teacher("Ali", new DateTime(1980, 1, 1), 291873932);
            teacher.account.InsertMoney(100.00f);
            var  student = new Student("mohammad", new DateTime(2000, 1, 1), 92173923);
            student.CreateBankAccount();
            teacher.account.Pay(50, student.account );
            Console.WriteLine("Teacher Balance: {0}$",teacher.account.Balance);
            Console.WriteLine("Student Balance: {0}$",student.account.Balance);
            teacher.account.AtmWithdraw(teacher.account.VisaCard);
            Console.WriteLine(teacher.account.Balance);
        }
    }
}
