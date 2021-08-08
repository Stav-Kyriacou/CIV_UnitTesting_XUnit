using System;
using Xunit;
using CalcLib;

namespace Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            RecursiveCalc calc = new RecursiveCalc();

            Assert.Throws<DivideByZeroException>(() => calc.PrimeCheckRec(9, 0));
        }

        [Fact]
        public void NegativeFactorialTest()
        {
            RecursiveCalc calc = new RecursiveCalc();

            Assert.Throws<StackOverflowException>(() => calc.FactorialRec(-2, 1));

        }

    }
}
