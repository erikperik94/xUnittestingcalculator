using System;
using Xunit;

namespace CalculatorConsoleApp.Test
{
    public class CalcTests
    {
        [Fact]
        public void CalcAddTest()
        {
            double[] myArr = { 1, 2, 3 };
            var call = new Caller(myArr);
            Assert.Equal(6,call.Addition(myArr));
            Assert.Equal(call.Addition(2,1), call.Addition(1, 2));
        }
        [Fact]
        public void CalcSubTest()
        {
            double[] myArr = { 1, 2, 3  };
            var call = new Caller(myArr);
            Assert.Equal( -6, call.Subtraction(myArr));
            Assert.Equal(call.Subtraction(1, 2), call.Subtraction(1, 2));
        }
        [Fact]
        public void CalcSubTestMinus()
        {
            double[] myArr = { -12, -3, 5, 24 };
            var call = new Caller(myArr);
            Assert.Equal(-38, call.Subtraction(myArr));
            Assert.Equal(call.Subtraction(1, 2), call.Subtraction(1, 2));
        }
        [Fact]
        public void CalcDivTest()
        {
            double num1 = 16;
            double num2 = 4;
            var call = new Caller(num1,num2);
            Assert.Equal(4,call.Division(num1,num2));
        }
        [Fact]
        public void CalcMultiTest()
        {
            double num1 = 4;
            double num2 = 4;
            var call = new Caller(num1, num2);
            Assert.Equal(16, call.Multiplication(num1, num2));
        }

    }
}
