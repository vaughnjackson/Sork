public class JumpCommand : ICommand
{
    public bool Handles(string userInput)
    {
        return userInput == "jump";
    }

    public CommandResult Execute()
    {
        Console.WriteLine("How high??!!");
        return new CommandResult { RequestExit = false, IsHandled = true };
    }
}
