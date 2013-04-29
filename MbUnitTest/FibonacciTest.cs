using System;
using MbUnitTest;
using MbUnit.Framework;

namespace MbUnitTest.Test
{
    public class FibonacciTest
    {
        [Test]
        public void Fibonacci_of_number_greater_than_one()
        {
            int result = Fibonacci.Calculate(6);
            Assert.AreEqual(8, result);
        }
    }
}