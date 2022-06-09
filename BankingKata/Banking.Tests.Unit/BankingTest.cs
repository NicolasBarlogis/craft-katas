using FluentAssertions;
using Xunit;

namespace Banking.Tests.Unit
{

    public class BankingTest
    {
        [Fact]
        public void WhenDepositMoney_ThenTheBalenceIsCorrect()
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
    }

}
