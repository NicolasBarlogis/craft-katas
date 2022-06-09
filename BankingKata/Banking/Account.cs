using System;

namespace Banking
{

    public class Account
    {
        private float _balance;

        public void Deposit(float amount)
        {
            _balance = _balance + amount;
        }

        public float GetBalance()
        {
            return _balance;
        }

        public void Withdraw(float amountToWithdraw)
        {
            _balance = _balance - amountToWithdraw;
        }

        public object GetStatement()
        {
            throw new NotImplementedException();
        }
    }

}
