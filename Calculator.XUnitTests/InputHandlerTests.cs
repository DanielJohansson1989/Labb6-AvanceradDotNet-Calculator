using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.XUnitTests
{
    public class InputHandlerTests
    {
        [Fact]
        public void ReceiveUserInput_UserInput_Is_6_Return_Double_6()
        {
            InputHandler inputHandler = new InputHandler();
            Mock<IUserInput> userInput = new Mock<IUserInput>();
            userInput.Setup(ui => ui.GetInput()).Returns("6");

            var actual = inputHandler.ReceiveUserInput(userInput.Object);
            var expected = 6d;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ReceiveUserInput_UserInput_Is_Letters_Should_Loop_Until_InputIsNumbers()
        {
            InputHandler inputHandler = new InputHandler();
            Mock<IUserInput> userInput = new Mock<IUserInput>();
            MockSequence sequence = new MockSequence();
            userInput.InSequence(sequence).Setup(input => input.GetInput()).Returns("asd");
            userInput.InSequence(sequence).Setup(input => input.GetInput()).Returns("12D");
            userInput.InSequence(sequence).Setup(input => input.GetInput()).Returns("12");

            var actual = inputHandler.ReceiveUserInput(userInput.Object);
            var expected = 12D;


            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ReceiveUserInput_UserInput_Is_10_5_Return_Double_10_5()
        {
            InputHandler inputHandler = new InputHandler();
            Mock<IUserInput> userInput = new Mock<IUserInput>();
            userInput.Setup(ui => ui.GetInput()).Returns("10,5");

            var actual = inputHandler.ReceiveUserInput(userInput.Object);
            var expected = 10.5d;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ReceiveUserInput_UserInput_Is_Negative6_Return_Double_Negative6()
        {
            InputHandler inputHandler = new InputHandler();
            Mock<IUserInput> userInput = new Mock<IUserInput>();
            userInput.Setup(ui => ui.GetInput()).Returns("-6");

            var actual = inputHandler.ReceiveUserInput(userInput.Object);
            var expected = -6d;

            Assert.Equal(expected, actual);
        }
    }
}
