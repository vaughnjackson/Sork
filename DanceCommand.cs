public class DanceCommand : ICommand
{
    public bool Handles(string userInput) => userInput == "dance";
    public CommandResult Execute()
    {
        Console.WriteLine("Get down and boogie!");
        return new CommandResult { RequestExit = false, IsHandled = true };
    }
}