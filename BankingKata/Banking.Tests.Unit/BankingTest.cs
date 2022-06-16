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
    }

}
