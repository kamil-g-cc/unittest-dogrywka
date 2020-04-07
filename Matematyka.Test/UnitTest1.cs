using System;
using Xunit;

namespace Matematyka.Test
{
    public class Matematyka_IsPrimeNumber_Should
    {
        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        public void IsPrimeNumber_InputLessThan2_ReturnFalse(int value)
        {
            var result = Math.IsPrimeNumber(value);
            Assert.False(result, $"{value} should not be a prime number!");
        }
    }
}
