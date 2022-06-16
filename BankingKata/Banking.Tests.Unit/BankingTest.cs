using System;
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
            var account = new Account();

            //Act
            account.Deposit(amount);

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
            
            var account = new Account();

            //Act
            account.Deposit(amount);
            account.Deposit(amount2);

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
            var dateTimeWithDraw = DateTime.Now;
            var account = new Account();

            //Act
            account.Deposit(amountToDeposit);
            account.Withdraw(amountToWithdraw, dateTimeWithDraw);

            //Assert
            var balance = account.GetBalance();
            balance.Should().Be(amountToDeposit - amountToWithdraw);
        }

        [Fact]
        public void WhenGetStatementOnFilledAccount_ThenStatementListIsCorrect()
        {
            //Arrange
            float amountToWithdraw = 500;
            var dateTimeWithDraw = DateTime.Now;
            var account = new Account();

            //Act
            account.Withdraw(amountToWithdraw, dateTimeWithDraw);
            var statement = account.GetStatement();

            //Assert
            statement.Amount.Should().Be(amountToWithdraw);
            statement.Date.Should().Be(dateTimeWithDraw);
        }
        [Fact]
        public void WhenGetStatementOnDepositOnFilledAccount_ThenStatementListIsCorrect()
        {
            //Arrange
            float amountToDeposit = 500;
            var dateTimeDeposit = DateTime.Now;
            var account = new Account();

            //Act
            account.Deposit(amountToDeposit, dateTimeDeposit);
            var statement = account.GetStatement();

            //Assert
            statement.Amount.Should().Be(amountToDeposit);
            statement.Date.Should().Be(dateTimeDeposit);

        }
    }

}
