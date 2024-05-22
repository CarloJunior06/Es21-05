using Es21_05;
using System.Numerics;
using Xunit;
namespace TestProject1
{
    public class UnitTest1
    {
        private Calculator _stringCalculator = new Calculator();

        [Fact]
        public void Should_Return_Sum_When_String_Contains_Two_Numbers()
        {
            string numbers = "1,2";
            int result = _stringCalculator.Add(numbers);
            Assert.Equal(3, result);
        }
        [Fact]
        public void Should_Return_Zero_When_String_Is_Empty()
        {
            string emptyString = "";
            int result = _stringCalculator.Add(emptyString);
            Assert.Equal(0, result);

        }
        [Fact]
        public void Should_Return_Hitself_When_String_Contains_One_Number()
        {
            string emptyString = "1";
            int result = _stringCalculator.Add(emptyString);
            Assert.Equal(1, result);
        }
        [Fact]
        public void Should_Not_Have_Different_Separator()
        {
            string numbers = "1.2";
            Assert.Throws<Exception>(() => _stringCalculator.Add(numbers));
        }
        [Fact]
        public void Should_Sum_Multiple_Numbers()
        {
            string numbers = "1,2,3,4,5,6";
            int result = _stringCalculator.Add(numbers);
            Assert.Equal(21, result);
        }
        [Fact]
        public void Should_Handle_New_Lines_Instead_Of_Comma()
        {
            string numbers = "1\n2,3";
            int result = _stringCalculator.Add(numbers);
            Assert.Equal(6, result);
        }
        [Fact]
        public void Should_Have_Separator_Followed_By_Number()
        {
            string numbers = "1,\n";
            Assert.Throws<Exception>(() => _stringCalculator.Add(numbers));
        }
        [Fact]
        public void Should_Sum_Separator_When_New_Separator()
        {
            string numbers = "//;\n1;2";
            int result = _stringCalculator.Add(numbers);
            Assert.Equal(3, result);
        }
        [Fact]
        public void Should_Return_Exception_If_Input_Numbers_Are_Megative()
        {
            string numbers = "1,-5,7,3,-8,-12";
            Exception error = Assert.Throws<Exception>(() => _stringCalculator.Add(numbers));
            Assert.Equal("negatives not allowed: -5, -8, -12", error.Message);
        }
        [Fact]
        public void Should_Avoid_Numbers_Greater_Than_1000()
        {
            string numbers = "//;\n1;2;249947";
            int result = _stringCalculator.Add(numbers);
            Assert.Equal(3, result);
        }
        /*public void Should_Handle_Multiple_Separator_Lenght() 
        [Fact]
        {
            string numbers = "//[***]\n1***2***3";
            int result = _stringCalculator.Add(numbers);
            Assert.Equal(6, result);
         */
    }
}