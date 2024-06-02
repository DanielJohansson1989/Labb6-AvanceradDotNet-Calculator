using Castle.Components.DictionaryAdapter.Xml;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.XUnitTests
{
    public class MainMenuTests
    {
        [Fact]
        public void RunMainMenu_UserInputIs_1_AdditionIsCalled()
        {
            //Arrange
            Mock<ICalculator> calculator = new Mock<ICalculator>();
            Mock<IOutputHandler> outputHandler = new Mock<IOutputHandler>();
            Mock<IUserInput> input = new Mock<IUserInput>();
            Mock<IHistory> history = new Mock<IHistory>();
            Mock<IConsole> console = new Mock<IConsole>();

            MainMenu mainMenu = new MainMenu(calculator.Object, outputHandler.Object, input.Object, history.Object, console.Object);

            calculator.Setup( c => c.Addition(It.IsAny<UserInput>(), history.Object)).Returns("Addition() called");

            input.SetupSequence(i => i.GetInput()).Returns("1").Returns("6").Returns("6");

            //Act
            mainMenu.RunMainMenu();

            //Assert
            calculator.Verify(c => c.Addition(It.IsAny<UserInput>(), history.Object));
        }

        [Fact]
        public void RunMainMenu_UserInput_2_SubtractionIsCalled()
        {
            //Arrange
            Mock<ICalculator> calculator = new Mock<ICalculator>();
            Mock<IOutputHandler> outputHandler = new Mock<IOutputHandler>();
            Mock<IUserInput> input = new Mock<IUserInput>();
            Mock<IHistory> history = new Mock<IHistory>();
            Mock<IConsole> console = new Mock<IConsole>();

            MainMenu mainMenu = new MainMenu(calculator.Object, outputHandler.Object, input.Object, history.Object, console.Object);

            calculator.Setup(c => c.Subtraction(input.Object, history.Object)).Returns("Subtraction() called");
            

            input.SetupSequence(i => i.GetInput()).Returns("2").Returns("6").Returns("6");

            //Act
            mainMenu.RunMainMenu();

            //Assert
            calculator.Verify(c => c.Subtraction(It.IsAny<UserInput>(), history.Object));
        }

        [Fact]
        public void RunMainMenu_UserInputIs_3_MultiplicationIsCalled()
        {
            //Arrange
            Mock<ICalculator> calculator = new Mock<ICalculator>();
            Mock<IOutputHandler> outputHandler = new Mock<IOutputHandler>();
            Mock<IUserInput> input = new Mock<IUserInput>();
            Mock<IHistory> history = new Mock<IHistory>();
            Mock<IConsole> console = new Mock<IConsole>();

            MainMenu mainMenu = new MainMenu(calculator.Object, outputHandler.Object, input.Object, history.Object, console.Object);

            calculator.Setup(c => c.Multiplication(input.Object, history.Object)).Returns("Multiplication() called");

            input.SetupSequence(i => i.GetInput()).Returns("3").Returns("6").Returns("6");

            //Act
            mainMenu.RunMainMenu();

            //Assert
            calculator.Verify(c => c.Multiplication(It.IsAny<UserInput>(), history.Object));
        }

        [Fact]
        public void RunMainMenu_UserInputIs_4_DivisionIsCalled()
        {
            //Arrange
            Mock<ICalculator> calculator = new Mock<ICalculator>();
            Mock<IOutputHandler> outputHandler = new Mock<IOutputHandler>();
            Mock<IUserInput> input = new Mock<IUserInput>();
            Mock<IHistory> history = new Mock<IHistory>();
            Mock<IConsole> console = new Mock<IConsole>();

            MainMenu mainMenu = new MainMenu(calculator.Object, outputHandler.Object, input.Object, history.Object, console.Object);

            calculator.Setup(c => c.Division(input.Object, history.Object)).Returns("Division() called");

            input.SetupSequence(i => i.GetInput()).Returns("4").Returns("6").Returns("6");

            //Act
            mainMenu.RunMainMenu();

            //Assert
            calculator.Verify(c => c.Division(It.IsAny<UserInput>(), history.Object));
        }

        [Fact]
        public void RunMainMenu_UserInputIs_5_GetRecordsIsCalled()
        {
            //Arrange
            Mock<ICalculator> calculator = new Mock<ICalculator>();
            Mock<IOutputHandler> outputHandler = new Mock<IOutputHandler>();
            Mock<IUserInput> input = new Mock<IUserInput>();
            Mock<IHistory> history = new Mock<IHistory>();
            Mock<IConsole> console = new Mock<IConsole>();

            MainMenu mainMenu = new MainMenu(calculator.Object, outputHandler.Object, input.Object, history.Object, console.Object);

            history.Setup(h => h.GetRecords()).Returns(new List<string> { "History() called" });

            input.SetupSequence(i => i.GetInput()).Returns("5").Returns("6").Returns("6");

            //Act
            mainMenu.RunMainMenu();

            //Assert
            history.Verify(h => h.GetRecords());
        }

        [Fact]
        public void RunMainMenu_UserInputIs_77_OutputHandler_InDefault_IsCalled()
        {
            //Arrange
            Mock<ICalculator> calculator = new Mock<ICalculator>();
            Mock<IOutputHandler> outputHandler = new Mock<IOutputHandler>();
            Mock<IUserInput> input = new Mock<IUserInput>();
            Mock<IHistory> history = new Mock<IHistory>();
            Mock<IConsole> console = new Mock<IConsole>();

            MainMenu mainMenu = new MainMenu(calculator.Object, outputHandler.Object, input.Object, history.Object, console.Object);

            outputHandler.Setup(oh => oh.PrintOutput(It.IsAny<string>()));

            input.SetupSequence(i => i.GetInput()).Returns("77").Returns("6").Returns("6");

            //Act
            mainMenu.RunMainMenu();

            //Assert
            outputHandler.Verify(oh => oh.PrintOutput(It.IsAny<string>()));
        }

        [Fact]
        public void RunMainMenu_UserInputIs_ASD_OutputHandler_InDefault_IsCalled()
        {
            //Arrange
            Mock<ICalculator> calculator = new Mock<ICalculator>();
            Mock<IOutputHandler> outputHandler = new Mock<IOutputHandler>();
            Mock<IUserInput> input = new Mock<IUserInput>();
            Mock<IHistory> history = new Mock<IHistory>();
            Mock<IConsole> console = new Mock<IConsole>();

            MainMenu mainMenu = new MainMenu(calculator.Object, outputHandler.Object, input.Object, history.Object, console.Object);

            outputHandler.Setup(oh => oh.PrintOutput(It.IsAny<string>()));

            input.SetupSequence(i => i.GetInput()).Returns("ASD").Returns("6").Returns("6");

            //Act
            mainMenu.RunMainMenu();

            //Assert
            outputHandler.Verify(oh => oh.PrintOutput(It.IsAny<string>()));
        }
    }
}
