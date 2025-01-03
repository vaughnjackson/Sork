public class Program
{
    public static void Main(string[] args)
    {
        do
        {
            Console.Write(" > ");
            string input = Console.ReadLine();
            input = input.ToLower();
            input = input.Trim();
            if (input == "lol") { Console.WriteLine("You laugh out loud!"); }
            else if (input == "exit") { break; }
            else if (input == "dance") { Console.WriteLine("Get down and boogie!"); }
            else if (input == "sing") { Console.WriteLine("If I was twice the man I could be, I'd be half of what you need!"); }
            else if (input == "whistle") { Console.WriteLine("Whistle while you work!"); }
            else { Console.WriteLine("Unknown command"); }
        } while (true);
    }
}
