using System;
using System.Collections.Generic;
using System.Linq;

namespace Banking
{
    public class Account
    {
        private float _balance;
        private IList<Statement> _statements = new List<Statement>();

        public Account() : this(0)
        {
        }

        public Account(float balance)
        {
            _balance = balance;
        }

        public void Deposit(float amount, DateTime statementDate)
        {
            _balance += amount;
            _statements.Add(new Statement(amount, _balance, statementDate));
        }

        public float GetBalance()
        {
            return _balance;
        }

        public void Withdraw(float amountToWithdraw, DateTime statementDate)
        {
            _balance -= amountToWithdraw;
            _statements.Add(new Statement(amountToWithdraw, statementDate));
        }

        public Statement GetStatement()
        {
            return _statements.Last(); 
        }

        public IList<Statement> GetStatements()
        {
            return _statements;
        }
    }
}
