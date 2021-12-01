using System;

namespace SonarMathTest
{
    public static class SimpleMath
    {
        public static int Add(int a, int b) => a + b;
        public static int Subtract(int a, int b) => a - b;
        public static decimal Divide (int a, int b) 
        {
            if (b == 0) 
            {
                throw new DivideByZeroException();
            }

            return (decimal)a / b;
        }

        public static decimal Multiply(int a, int b)
        {
            return a * b;
        }

        public static decimal Remainder(int a, int b)
        {
            return a % b;
        }

        public static decimal Square(int a)
        {
            return a * a;
        }

        public static decimal Cube(int a)
        {
            return a * a * a;
        }
    }
}