using System;

namespace Banking
{

    public class Account
    {
        private float _balance;
        private Statement _statement;

        public void Deposit(float amount)
        {
            _balance = _balance + amount;
        }
        public void Deposit(float amount, DateTime statementDate)
        {
            throw new NotImplementedException();
        }

        public float GetBalance()
        {
            return _balance;
        }

        public void Withdraw(float amountToWithdraw, DateTime statementDate )
        {
            _balance = _balance - amountToWithdraw;
            _statement = new Statement(amountToWithdraw,statementDate);
        }

        public Statement GetStatement()
        {
            return _statement;
        }
    }

}
