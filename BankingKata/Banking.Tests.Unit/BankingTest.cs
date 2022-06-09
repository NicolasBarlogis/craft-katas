using System;
using Xunit;

namespace Banking.Tests.Unit
{

    public class BankingTest
    {
        [Fact]
        public void Test_Deposit_And_Withdrawl()
        {
            //Arr
            var compte = new Account();

            //Act
            compte.deposit(15);
            var balance = compte.balance();

            //Assert
            Assert.Equal(15, balance);
            
        }
    }

}
