using System;

namespace Banking
{

    public class Account
    {
        private float _balance;

        public void Deposit(float amount)
        {
            _balance = amount;
        }

        public float GetBalance()
        {
            return _balance;
        }
    }

}
