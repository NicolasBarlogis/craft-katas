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
    }

}
