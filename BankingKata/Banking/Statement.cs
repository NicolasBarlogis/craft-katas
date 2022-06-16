using System;

namespace Banking
{
    public class Statement
    {
        public float Amount { get; set; }
        public float Balance { get; set; }
        public DateTime Date { get; set; }

        public Statement(float amount,float balance, DateTime date)
        {
            Amount = amount;
            Balance = balance;
            Date = date;
        }

        public Statement(float amount, DateTime date)
        {
            Amount = amount;
            Date = date;
        }
    }
}
