namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            History history = new History();
            Calculator calculator = new Calculator();
            OutputHandler outputHandler = new OutputHandler();
            UserInput userInput = new UserInput();
            OutputRemover outputRemover = new OutputRemover();

            MainMenu app = new MainMenu(calculator, outputHandler, userInput, history, outputRemover);
            
            app.RunMainMenu();

            
        }
    }
}
