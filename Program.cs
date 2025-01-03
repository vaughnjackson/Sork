public class Program
{
    public static void Main(string[] args)
    {
        var commands = new List<ICommand>
        {
            new LaughCommand(),
            new ExitCommand(),
            new DanceCommand(),
            new SingCommand(),
            new WhistleCommand(),
            new JumpCommand()
        };

        do
        {
            Console.Write(" > ");
            string input = Console.ReadLine();
            input = input.ToLower();
            input = input.Trim();

            var result = new CommandResult { RequestExit = false, IsHandled = false };
            var handled = false;
            foreach (var command in commands)
            {
                if (command.Handles(input))
                {
                    handled = true;
                    result = command.Execute();
                    if (result.RequestExit) { break; }
                }
            }
            if (!handled) { Console.WriteLine("Unknown command"); }
            if (result.RequestExit) { break; }

        } while (true);
    }
}

public interface ICommand
{
    bool Handles(string userInput);
    CommandResult Execute();
}

public class ExitCommand : ICommand
{
    public bool Handles(string userInput) => userInput == "exit";
    public CommandResult Execute()
    {
        Console.WriteLine("Exiting...");
        return new CommandResult { RequestExit = true, IsHandled = true };
    }
}

public class DanceCommand : ICommand
{
    public bool Handles(string userInput) => userInput == "dance";
    public CommandResult Execute()
    {
        Console.WriteLine("Get down and boogie!");
        return new CommandResult { RequestExit = false, IsHandled = true };
    }
}

public class SingCommand : ICommand
{
    public bool Handles(string userInput) => userInput == "sing";
    public CommandResult Execute()
    {
        Console.WriteLine("If I was twice the man I could be, I'd be half of what you need!");
        return new CommandResult { RequestExit = false, IsHandled = true };
    }
}

public class WhistleCommand : ICommand
{
    public bool Handles(string userInput) => userInput == "whistle";
    public CommandResult Execute()
    {
        Console.WriteLine("Whistle while you work!");
        return new CommandResult { RequestExit = false, IsHandled = true };
    }
}

public class JumpCommand : ICommand
{
    public bool Handles(string userInput) => userInput == "jump";
    public CommandResult Execute()
    {
        Console.WriteLine("How high??!!");
        return new CommandResult { RequestExit = false, IsHandled = true };
    }
}

public class CommandResult
{
    public bool RequestExit { get; set; }

    public bool IsHandled { get; set; }
}

public class LaughCommand : ICommand
{
    public bool Handles(string userInput) => userInput == "lol";
    public CommandResult Execute()
    {
        Console.WriteLine("You laugh out loud!");
        return new CommandResult { RequestExit = false, IsHandled = true };
    }
}