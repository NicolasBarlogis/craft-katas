using System;
using System.Linq;
using FluentAssertions;
using Xunit;

namespace Banking.Tests.Unit
{

    public class BankingTest
    {
        [Fact]
        public void WhenDepositMoneyOnEmptyAccount_ThenTheBalanceIsCorrect()
        {
            //Arrange
            float amount = 500;
            var dateTimeDeposit = DateTime.Now;
            var account = new Account();

            //Act
            account.Deposit(amount, dateTimeDeposit);

            //Assert
            var balance = account.GetBalance();
            balance.Should().Be(amount);
        }

        [Fact]
        public void WhenDepositMoneyOnNotEmptyAccount_ThenTheBalanceIsCorrect()
        {
            //Arrange
            float amount = 500;
            float amount2 = 500;
            var dateTimeDeposit = DateTime.Now;

            var account = new Account();

            //Act
            account.Deposit(amount, dateTimeDeposit);
            account.Deposit(amount2, dateTimeDeposit);

            //Assert
            var balance = account.GetBalance();
            balance.Should().Be(amount+amount2);
        }

        [Fact]
        public void WhenWithdrawMoneyOnEmptyAccount_ThenTheBalanceIsCorrect()
        {
            //Arrange
            float amountToWithdraw = 500;
            var dateTimeWithDraw = DateTime.Now;
            var account = new Account();

            //Act
            account.Withdraw(amountToWithdraw, dateTimeWithDraw);

            //Assert
            var balance = account.GetBalance();
            balance.Should().Be(-amountToWithdraw);
        }

        [Fact]
        public void WhenWithdrawMoneyOnFilledAccount_ThenTheBalanceIsCorrect()
        {
            //Arrange
            float amountToDeposit = 1500;
            float amountToWithdraw = 500;
            var dateTimeDeposit = DateTime.Now;
            var dateTimeWithDraw = DateTime.Now;
            var account = new Account();

            //Act
            account.Deposit(amountToDeposit, dateTimeDeposit);
            account.Withdraw(amountToWithdraw, dateTimeWithDraw);

            //Assert
            var balance = account.GetBalance();
            balance.Should().Be(amountToDeposit - amountToWithdraw);
        }

        [Fact]
        public void WhenGetStatementsOnFilledAccount_ThenStatementListIsCorrect()
        {
            //Arrange
            float amountToDeposit = 500;
            float amountToWithdraw = 100;
            var dateTimeDeposit = DateTime.Now;
            var dateTimeWithdraw = DateTime.Now.AddDays(1);
            var account = new Account();

            //Act
            account.Deposit(amountToDeposit, dateTimeDeposit);
            account.Withdraw(amountToWithdraw, dateTimeWithdraw);
            var statements = account.GetStatements();

            //Assert
            statements.Should().HaveCount(2);

            var depositStatement = statements.First();
            depositStatement.Date.Should().Be(dateTimeDeposit);
            depositStatement.Amount.Should().Be(amountToDeposit);

            var withdrawStatement = statements.Last();
            withdrawStatement.Date.Should().Be(dateTimeWithdraw);
            withdrawStatement.Amount.Should().Be(amountToWithdraw);
        }

        [Fact]
        public void WhenGetStatementOnDepositOnFilledAccount_ThenStatementIsCorrect()
        {
            //Arrange
            float amountToDeposit = 500;
            var dateTimeDeposit = DateTime.Now;
            var account = new Account(500);
             
            //Act
            account.Deposit(amountToDeposit, dateTimeDeposit);
            var statement = account.GetStatement();

            //Assert
            statement.Amount.Should().Be(amountToDeposit);
            statement.Date.Should().Be(dateTimeDeposit);
            statement.Balance.Should().Be(1000);
        }

        [Fact]
        public void WhenGetStatementOnWithdrawOnFilledAccount_ThenStatementIsCorrect()
        {
            //Arrange
            float amountToWithdraw = 500;
            var dateTimeWithdraw = DateTime.Now;
            var account = new Account(500);

            //Act
            account.Withdraw(amountToWithdraw, dateTimeWithdraw);
            var statement = account.GetStatement();

            //Assert
            statement.Amount.Should().Be(amountToWithdraw);
            statement.Date.Should().Be(dateTimeWithdraw);
            statement.Balance.Should().Be(1000);
        }
    }
}
