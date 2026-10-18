using TestableApp;
using Xunit;

namespace TestableApp.Tests
{
    public class CalculatorTests
    {
        private readonly Calculator _calc = new Calculator();

        // 1. Корректные значения
        [Fact]
        public void Add_TwoPositiveNumbers_ReturnsSum()
        {
            Assert.Equal(5, _calc.Add(2, 3));
        }

        // 2. Граничное условие (максимальное значение)
        [Fact]
        public void Add_MaxValueAndZero_ReturnsMaxValue()
        {
            Assert.Equal(int.MaxValue, _calc.Add(int.MaxValue, 0));
        }

        // 3. Корректное деление
        [Fact]
        public void Divide_TenByTwo_ReturnsFive()
        {
            Assert.Equal(5, _calc.Divide(10, 2));
        }

        // 4. Обработка исключительной ситуации (деление на ноль)
        [Fact]
        public void Divide_ByZero_ThrowsDivideByZeroException()
        {
            Assert.Throws<DivideByZeroException>(() => _calc.Divide(10, 0));
        }

        // 5. Граничное условие (ноль не является положительным)
        [Fact]
        public void IsPositive_Zero_ReturnsFalse()
        {
            Assert.False(_calc.IsPositive(0));
        }

        // 6. Граничное условие (отрицательное число)
        [Fact]
        public void IsPositive_NegativeNumber_ReturnsFalse()
        {
            Assert.False(_calc.IsPositive(-5));
        }

        // 7. Корректное значение для IsPositive
        [Fact]
        public void IsPositive_PositiveNumber_ReturnsTrue()
        {
            Assert.True(_calc.IsPositive(1));
        }
    }
}