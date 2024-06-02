using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class MainMenu
    {
        private readonly ICalculator _calculator;
        private readonly IOutputHandler _outputHandler;
        private readonly IUserInput _userInput;
        private readonly IHistory _history;
        private readonly IConsole _console;
        private bool _turnOffMenu = false;

        public MainMenu(ICalculator calculator, IOutputHandler outputHandler, IUserInput userInput, IHistory history, IConsole console)
        {
            _calculator = calculator;
            _outputHandler = outputHandler;
            _userInput = userInput;
            _history = history;
            _console = console;
        }
        public void RunMainMenu()
        {
            UserInput userInput = new UserInput();
            List<string> menu = new List<string>() 
            {
                "Main Menu:",
                "1. Addition",
                "2. Subtraction",
                "3. Multiplication",
                "4. Division",
                "5. History",
                "6. Turn off"
            };

            do
            {
                _console.ClearWindow();
                _outputHandler.PrintOutput(menu);

                switch (_userInput.GetInput())
                {
                    case "1":
                        _console.ClearWindow();
                        string sum = _calculator.Addition(userInput, _history);
                        _outputHandler.PrintOutput(sum);
                        _userInput.GetInput();
                        break;
                    case "2":
                        _console.ClearWindow();
                        string difference = _calculator.Subtraction(userInput, _history);
                        _outputHandler.PrintOutput(difference);  
                        _userInput.GetInput();
                        break;
                    case "3":
                        _console.ClearWindow();
                        string product = _calculator.Multiplication(userInput, _history);
                        _outputHandler.PrintOutput(product);
                        _userInput.GetInput();
                        break;
                    case "4":
                        _console.ClearWindow();
                        string quotient = _calculator.Division(userInput, _history);
                        _outputHandler.PrintOutput(quotient);
                        _userInput.GetInput();
                        break;
                    case "5":
                        _console.ClearWindow();
                        _outputHandler.PrintOutput(_history.GetRecords());
                        _userInput.GetInput();
                        break;
                    case "6":
                    _turnOffMenu = true; 
                    break;
                    default:
                        _console.ClearWindow();
                        _outputHandler.PrintOutput("Invalid input!");
                        _userInput.GetInput();
                        break;
                }
           } while (!_turnOffMenu);
        }
    }
}
