using System;

namespace Banking
{

    public class Account
    {
        private float deposit;

        public void Deposit(float money)
        {
            deposit = money;
        }

        public float Balance()
        {
            return deposit;
        }
    }

}
