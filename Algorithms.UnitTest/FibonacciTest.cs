using System;
using Xunit;

namespace Fibonacci.UnitTest
{
    public class FibonacciTest
    {
        [Theory]
        [InlineData(90, 2880067194370816120)]
        [InlineData(12, 144)]
        [InlineData(10, 55)]
        [InlineData(-10, 55)]

        public void TestFibonacciNumber(long input, long expectedSum)
        {
            //Arrange
            var fibonacci = new Algorithms.Fibonacci();

            //Act
            var actualSum = fibonacci.GetFibonacciNumber(input);

            //Assert
            Assert.Equal(expectedSum, actualSum);
        }


        [Theory]
        [InlineData(93)]
        [InlineData(94)]
        [InlineData(95)]

        public void TestOverflowExceptionForFibonacciNumber(long input)
        {
            //Arrange
            var fibonacci = new Algorithms.Fibonacci();

            //Assert
            Assert.Throws<OverflowException>(() => fibonacci.GetFibonacciNumber(input));
        }
    }
}
