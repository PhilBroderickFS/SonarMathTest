using System;
using SonarMathTest;
using Xunit;

namespace Math.Tests
{
    public class SimpleMathTests
    {
        [Fact]
        public void Add_WhenCalled_ReturnsAdditionOfInput()
        {
            var result = SimpleMath.Add(1, 1);
            
            Assert.Equal(2, result);
        }

        [Fact]
        public void Subtract_WhenCalled_ReturnsSubtractionOfInput()
        {
            var result = SimpleMath.Subtract(2, 1);
            
            Assert.Equal(1, result);
        }

        [Fact]
        public void Divide_NonZeroInput_ReturnsDivisionOfInput()
        {
            var result = SimpleMath.Divide(4, 2);
            
            Assert.Equal(2, result);
        }

        [Fact]
        public void Divide_ZeroInput_ThrowsDivideByZeroException()
        {
            Assert.Throws<DivideByZeroException>(() => SimpleMath.Divide(1, 0));
        }

        [Fact]
        public void Multiply_WhenCalled_ReturnsMultiplicationOfInput()
        {
            var result = SimpleMath.Multiply(1, 2);
            
            Assert.Equal(2, result);
        }

        [Fact]
        public void Remainder_WhenCalled_ReturnsRemainderOfInput()
        {
            var result = SimpleMath.Remainder(3, 2);
            
            Assert.Equal(1, result);
        }

        [Fact]
        public void Square_WhenCalled_ReturnsSquareOfInput()
        {
            var result = SimpleMath.Square(2);
            
            Assert.Equal(4, result);
        }
    }
}