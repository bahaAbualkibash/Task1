using System;

namespace Task1
{
    public class Teacher : Person
    {
        public CurrentAccount account ;

        public Teacher(string name, DateTime birthdate, int nationalId) : base(name, birthdate, nationalId)
        {
            account = new CurrentAccount(this);
        }

        public Teacher(Info generalInfo) : base(generalInfo)
        {
            account = new CurrentAccount(this);
        }

      

        
    }
}