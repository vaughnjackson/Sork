namespace Sork.Commands;

public class SingCommand : BaseCommand
{
    private readonly UserInputOutput io;
    public SingCommand(UserInputOutput io)
    {
        this.io = io;
    }
    public override bool Handles(string userInput) => GetCommandFromInput(userInput) == "sing";
    public override CommandResult Execute()
    {
        io.WriteMessageLine("If I was twice the man I could be, I'd be half of what you need!");
        return new CommandResult { RequestExit = false, IsHandled = true };
    }
}