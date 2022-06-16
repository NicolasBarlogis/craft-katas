using FluentAssertions;
using System;
using Xunit;

namespace Banking.Tests.Unit
{

    public class BankingTest
    {
        [Fact]
        public void When_Deposit_15_Then_Balance_Should_Be_15()
        {
            //Arr
            var compte = new Account();

            //Act
            compte.Deposit(15);
            var balance = compte.Balance();

            //Assert
            balance.Should().Be(15);
        }

        [Fact]
        public void When_Deposit_30_Then_Balance_Should_Be_30()
        {
            //Arr
            var compte = new Account();

            //Act
            compte.Deposit(30);
            var balance = compte.Balance();

            //Assert
            balance.Should().Be(30);
        }

        [Fact]
        public void When_Two_Deposit_15_Then_Balance_Should_Be_30()
        {
            //Arr
            var compte = new Account();

            //Act
            compte.Deposit(15);
            compte.Deposit(15);
            var balance = compte.Balance();

            //Assert
            balance.Should().Be(30);
        }

        [Fact]
        public void When_Deposit_30_And_Withdrawal_15_Then_Balance_Should_Be_15()
        {
            //Arr
            var compte = new Account();

            //Act
            compte.Deposit(30);
            compte.Withdrawal(15);
            var balance = compte.Balance();

            //Assert
            balance.Should().Be(15);
        }

        [Fact]
        public void When_Deposit_30_And_Withdrawal_40_Then_Balance_Should_Be_Minus_10()
        {
            //Arr
            var compte = new Account();

            //Act
            compte.Deposit(30);
            compte.Withdrawal(40);
            var balance = compte.Balance();

            //Assert
            balance.Should().Be(-10);
        }
    }

}
