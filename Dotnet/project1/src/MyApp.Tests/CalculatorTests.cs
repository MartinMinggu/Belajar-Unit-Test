using MyApp.services;

namespace MyApp.Tests
{
    public class CalculatorTest
    {
        [Fact]
        public void Add_ShouldReturnCprrectSum()
        {
            var calculator = new Calculator();
            var result = calculator.Add(3, 5);
            Assert.Equal(8, result);
        }

        [Fact]
        public void Divide_ByZerk_ShouldThrowException()
        {
            var calculator = new Calculator();
            Assert.Throws<DivideByZeroException>(() =>
            {
                calculator.Divdie(10, 0);
            });
        }
    }
}