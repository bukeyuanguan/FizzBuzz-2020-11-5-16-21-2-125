using System;
using FizzBuzzWhizz;
using Moq;
using Xunit;

namespace FizzBuzzWhizzTest
{
    public class FizzBuzzWhizzTest
    {
        [Fact]
        public void Should_Return_1_Given_1()
        {
            //given
            int given = 1;

            //when
            string actual = FizzBuzzWhizz.FizzBuzzWhizz.Say(given);
            string expected = "1";

            //then
            Assert.Equal(actual, expected);
        }
    }
}
