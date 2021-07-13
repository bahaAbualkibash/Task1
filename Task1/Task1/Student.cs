
using System;

namespace Task1
{
    public class Student : Person
    {

        public SavingsAccount account;
        public Student(string name, DateTime birthdate, int nationalId) : base(name, birthdate, nationalId)
        {
            // account = null;

        }

        public Student(Info generalInfo) : base(generalInfo)
        {
            // account = null;

        }
        public void CreateBankAccount()
        {
            account = new SavingsAccount(this);
        }

       
    }
}