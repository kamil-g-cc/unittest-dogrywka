using System;
using Xunit;

namespace Matematyka.Test
{
    public class Matematyka_IsPrimeNumber_Should
    {
        [Fact]
        public void IsPrimeNumber_Input1_ReturnFalse()
        {
            var result = Math.IsPrimeNumber(1);
            Assert.False(result, "1 should not be a prime number!");
        }
    }
}
