using ClassLibrary1;

namespace TestProject1
{
    public class UnitTest1
    {
        private readonly StringCalculator _calculator;

        public UnitTest1()
        {
            _calculator = new StringCalculator();
        }

        [Fact]
        public void ZeroTest()
        {
            Assert.Equal(0, _calculator.Add(""));
        }

        [Theory]
        [InlineData("2",2)]
        [InlineData("3", 3)]
        [InlineData("33", 33)]
        [InlineData("4511", 4511)]
        public void WhenStringProvided_ItShouldReturnItsValue(string input, int output)
        {
            Assert.Equal(output, _calculator.Add(input));
        }

        [Theory]
        [InlineData("2,2", 4)]
        [InlineData("3,2", 5)]
        [InlineData("33,44", 77)]
        [InlineData("4511,-5", 4506)]
        public void WhenStringWithOneCOmaProvided_ItShouldReturnSumOfValues(string input, int output)
        {
            Assert.Equal(output, _calculator.Add(input));
        }
        [Theory]
        [InlineData("2\n2", 4)]
        [InlineData("3\n2", 5)]
        [InlineData("33\n44", 77)]
        [InlineData("4511\n-5", 4506)]
        public void WhenStringWithOneEnterProvided_ItShouldReturnSumOfValues(string input, int output)
        {
            Assert.Equal(output, _calculator.Add(input));
        }
    }
}