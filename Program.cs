using System.Runtime.CompilerServices;

public static class Program
{
    static void Main()
    {
        System.Console.WriteLine("Enter Your name:");
        string playername = Console.ReadLine()!;
        Player player = new Player(playername);
        Console.Clear();
        System.Console.WriteLine("Enter Amount to gamble with:");
        int money = Convert.ToInt32(Console.ReadLine()!);
        Console.Clear();
    }
}