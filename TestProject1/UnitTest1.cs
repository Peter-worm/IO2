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
            Assert.Equal(output,_calculator.Add(input));
        }
    }
}