using System;

namespace Task1
{
    public class CurrentAccount : IAccount
    {
        public Info User { get; set; }
        public double Balance { get; set; }
        public string VisaCard { get; set; }
        public double Interest { get; set; }

        public CurrentAccount(Person peron)
        {
            User = peron.GeneralInfo;
            Balance = 0;
            VisaCard = generateVisa();
            Interest = 0.25;
            
        }
        private string generateVisa()
        {
            var visa = "";
            var random = new Random();
            for (var i = 0; i < 16; i++)
            {
                visa += Convert.ToString(random.Next(0, 9));

            }
            return visa;
        }

        public void Pay(double amount,IAccount account)
        {
            if (Validate(amount))
            {
                return;
            }
            if (this.Balance > 0  && amount < Balance)
            {
                Balance -= amount;
                account.Balance += amount;
            }
            else
            {
                Console.WriteLine("Your Balance is {0}... cancel payment",Balance);
            }
        

        }


        public void InsertMoney(double amountOfMoney)
        {
            if (Validate(amountOfMoney))
            {
                return;
            }
            if (Balance >= 0)
            {
                var reduce = amountOfMoney * 0.25;
                amountOfMoney -=  reduce;
                Balance += amountOfMoney;

            }
            else
            {
                Balance += amountOfMoney;
            }

        }

        public bool Validate(double amount)
        {
            if (!(amount < 0)) return false;
            Console.WriteLine("Negative number is not allowed"); 
            return true;
        }

                public void AtmWithdraw(string visaCard)
        {
            if (VisaCard.Equals(visaCard))
            {
                Console.WriteLine("Insert How much you want withdraw");
                var amount = Convert.ToInt32(Console.ReadLine());
                if (amount < Balance && amount > 0)
                {
                    Balance -= amount;
                    Console.WriteLine("You have withdrew {0}$",amount);
                }
                else
                {
                    Console.WriteLine("You don't have enough balance");
                }

            }
        }
    }
}