using System;
using Xunit;

namespace DedMoroz.Tests
{
    public class ProgramTests
    {
        [Theory]
        [InlineData("10 25 15 40", 3)]  // Пример входных данных и ожидаемого результата
        [InlineData("5 10 20 30", 3)]
        [InlineData("7 14 21 35", 2)]
        [InlineData("1 2 3 4", 4)]
        [InlineData("10 20 30 60", 55)]
        public void CalculateSum_ValidInput_ReturnsExpectedSum(string input, int expected)
        {
            int result = Program.CalculateSum(input);
            Assert.Equal(expected, result);
        }
    }
}
