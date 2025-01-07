namespace Sork.Commands;
using Sork.World;
public class JumpCommand : BaseCommand
{
    private readonly UserInputOutput io;
    public JumpCommand(UserInputOutput io)
    {
        this.io = io;
    }
    public override bool Handles(string userInput)
    {
        return GetCommandFromInput(userInput) == "jump";
    }

    public override CommandResult Execute(string userInput, GameState gameState)
    {
        io.WriteMessageLine("How high??!!");
        return new CommandResult { RequestExit = false, IsHandled = true };
    }
}
