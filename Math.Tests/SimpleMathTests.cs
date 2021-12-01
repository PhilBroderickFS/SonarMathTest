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

        // [Fact]
        // public void Divide_NonZeroInput_ReturnsDivisionOfInput()
        // {
        //     var result = SimpleMath.Divide(4, 2);
        //     
        //     Assert.Equal(2, result);
        // }
    }
}