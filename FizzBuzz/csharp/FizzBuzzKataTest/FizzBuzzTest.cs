using System;
using FizzBuzzKata;
using Xunit;

namespace FizzBuzzKataTest
{
    public class FizzBuzzTest
    {
        
        [Fact]
        public void foo()
        {
            var fizzBuzz = new FizzBuzz();
            Assert.Equal("fizz",fizzBuzz.AnswerFor(3));
        }
    }
}