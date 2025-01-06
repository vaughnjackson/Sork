public class SingCommand : ICommand
{
    public bool Handles(string userInput) => userInput == "sing";
    public CommandResult Execute()
    {
        Console.WriteLine("If I was twice the man I could be, I'd be half of what you need!");
        return new CommandResult { RequestExit = false, IsHandled = true };
    }
}