using System;

namespace Task1
{
    public interface IAccount
    {
        public Info User { get; set; }
        public double Balance { set; get; }
         string VisaCard { get; set; }

         double Interest { get; set; }

        public void Pay(double amount, IAccount visaCard);

         public void InsertMoney(double amountOfMoney);

         public bool Validate(double amount);

         public void AtmWithdraw(string visaCard);



    }
}