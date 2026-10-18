using System;

namespace TestableApp
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Divide(int a, int b)
        {
            if (b == 0)
                throw new DivideByZeroException("Деление на ноль невозможно.");
            return a / b;
        }

        public bool IsPositive(int number)
        {
            return number > 0;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }
    }
}