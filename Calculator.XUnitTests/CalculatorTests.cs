using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.XUnitTests
{
    public class CalculatorTests
    {
        [Theory]
        [InlineData("9", "5", "4")]
        [InlineData("50,35", "0,99", "49,36")]
        [InlineData("-5,5", "7", "-12,5")]
        [InlineData("-10", "-5", "-5")]
        [InlineData("5,55555555555555", "2,22222222222222", "3,33333333333333")]
        public void Subtraction_SetTwoNumbersAsInput_ShouldReturnExpected(string minuend, string subtrahend, string expected)
        {
            //Arrange
            Calculator calculator = new Calculator();
            Mock<IUserInput> fakeUserInput = new Mock<IUserInput>();
            Mock<IHistory> history = new Mock<IHistory>();

            fakeUserInput.SetupSequence(input => input.GetInput()).Returns(minuend).Returns(subtrahend);

            //Act
            var actual = calculator.Subtraction(fakeUserInput.Object, history.Object);

            //Assert 
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Subtraction_UserInputIsLetters_ShouldLoopAndAcceptNewInput()
        {
            //Arrange
            Calculator calculator = new Calculator();
            Mock<IUserInput> fakeUserInput = new Mock<IUserInput>();
            Mock<IHistory> history = new Mock<IHistory>();

            fakeUserInput.SetupSequence(input => input.GetInput()).Returns("asd").Returns("10").Returns("T").Returns("2");

            //Act
            var actual = calculator.Subtraction(fakeUserInput.Object, history.Object);
            var expected = "8";

            //Assert 
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("5", "5", "10")]
        [InlineData("44,4", "7,7777", "52,1777")]
        [InlineData("-5,5", "7", "1,5")]
        [InlineData("-10", "-5", "-15")]
        [InlineData("2,22222222222222", "3,33333333333333", "5,55555555555555")]
        public void Addition_InputTwoNumbers_ShouldReturnExpected(string augend, string addend, string expected)
        {
            //Arrange
            Calculator calculator = new Calculator();
            Mock<IUserInput> fakeUserInput = new Mock<IUserInput>();
            Mock<IHistory> history = new Mock<IHistory>();

            fakeUserInput.SetupSequence(input => input.GetInput()).Returns(augend).Returns(addend);

            //Act
            var actual = calculator.Addition(fakeUserInput.Object, history.Object);

            //Assert 
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Addition_UserInputIsLetters_ShouldLoopAndAcceptNewInput()
        {
            //Arrange
            Calculator calculator = new Calculator();
            Mock<IUserInput> fakeUserInput = new Mock<IUserInput>();
            Mock<IHistory> history = new Mock<IHistory>();

            fakeUserInput.SetupSequence(input => input.GetInput()).Returns("asd").Returns("10").Returns("T").Returns("2");

            //Act
            var actual = calculator.Addition(fakeUserInput.Object, history.Object);
            var expected = "12";

            //Assert 
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("5", "5", "25")]
        [InlineData("4,5", "1,99", "8,955")]
        [InlineData("-5", "7", "-35")]
        [InlineData("-10", "-5", "50")]
        [InlineData("8", "0", "0")]
        public void Multiplication_InputIsTwoNumbers_ShouldReturnExpected(string multiplicand, string multiplier, string expected)
        {
            //Arrange
            Calculator calculator = new Calculator();
            Mock<IUserInput> fakeUserInput = new Mock<IUserInput>();
            Mock<IHistory> history = new Mock<IHistory>();

            fakeUserInput.SetupSequence(input => input.GetInput()).Returns(multiplicand).Returns(multiplier);

            //Act
            var actual = calculator.Multiplication(fakeUserInput.Object, history.Object);

            //Assert 
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Multiplication_UserInputIsLetters_ShouldLoopAndAcceptNewInput()
        {
            //Arrange
            Calculator calculator = new Calculator();
            Mock<IUserInput> fakeUserInput = new Mock<IUserInput>();
            Mock<IHistory> history = new Mock<IHistory>();

            fakeUserInput.SetupSequence(input => input.GetInput()).Returns("asd").Returns("10").Returns("T").Returns("2");

            //Act
            var actual = calculator.Multiplication(fakeUserInput.Object, history.Object);
            var expected = "20";

            //Assert 
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("36", "6", "6")]
        [InlineData("2", "16", "0,125")]
        [InlineData("-5", "5", "-1")]
        [InlineData("-10", "-5", "2")]
        [InlineData("2", "0,5", "4")]
        public void Division_InputTwoNumbers_SholdReturnExpected(string dividend, string divisor, string expected)
        {
            //Arrange
            Calculator calculator = new Calculator();
            Mock<IUserInput> fakeUserInput = new Mock<IUserInput>();
            Mock<IHistory> history = new Mock<IHistory>();

            fakeUserInput.SetupSequence(input => input.GetInput()).Returns(dividend).Returns(divisor);

            //Act
            var actual = calculator.Division(fakeUserInput.Object, history.Object);

            //Assert 
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Division_TryDivideByZero_ShouldIterateAndAcceptNewIput()
        {
            //Arrange
            Calculator calculator = new Calculator();
            Mock<IUserInput> fakeUserInput = new Mock<IUserInput>();
            Mock<IHistory> history = new Mock<IHistory>();

            fakeUserInput.SetupSequence(input => input.GetInput()).Returns("6").Returns("0").Returns("3");

            //Act
            var actual = calculator.Division(fakeUserInput.Object, history.Object);
            var expected = "2";

            //Assert 
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Division_UserInputIsLetters_ShouldIterateAndAcceptNewInput()
        {
            //Arrange
            Calculator calculator = new Calculator();
            Mock<IUserInput> fakeUserInput = new Mock<IUserInput>();
            Mock<IHistory> history = new Mock<IHistory>();

            fakeUserInput.SetupSequence(input => input.GetInput()).Returns("asd").Returns("10").Returns("T").Returns("2");

            //Act
            var actual = calculator.Division(fakeUserInput.Object, history.Object);
            var expected = "5";

            //Assert 
            Assert.Equal(expected, actual);
        }
    }
}
