using System;

namespace Task1
{
    public abstract class Person
    {
        public Info GeneralInfo = new Info();

        protected Person(string name, DateTime birthdate,int nationalId)
        {
            GeneralInfo.name = name;
            GeneralInfo.BirthDate = birthdate;
            GeneralInfo.nationalId = nationalId;
          

        }


        protected Person(Info generalInfo)
        {
            GeneralInfo = generalInfo;
        }
      



    }
}