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
        private bool _turnOffMenu = false;

        public MainMenu(ICalculator calculator, IOutputHandler outputHandler, IUserInput userInput, IHistory history)
        {
            _calculator = calculator;
            _outputHandler = outputHandler;
            _userInput = userInput;
            _history = history;
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
                _outputHandler.PrintOutput(menu);

                switch (_userInput.GetInput())
                {
                    case "1":
                         string sum = _calculator.Addition(userInput, _history);
                        _outputHandler.PrintOutput(sum);
                        break;
                    case "2":
                        string difference = _calculator.Subtraction(userInput, _history);
                        _outputHandler.PrintOutput(difference);   
                        break;
                    case "3":
                        string product = _calculator.Multiplication(userInput, _history);
                        _outputHandler.PrintOutput(product);
                        break;
                    case "4":
                        string quotient = _calculator.Division(userInput, _history);
                        _outputHandler.PrintOutput(quotient);
                        break;
                    case "5":
                        _outputHandler.PrintOutput(_history.GetRecords());
                        break;
                    case "6":
                    _turnOffMenu = true; 
                    break;
                    default:
                        _outputHandler.PrintOutput("Invalid input!");
                        break;
                }
           } while (!_turnOffMenu);
        }
    }
}
