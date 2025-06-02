using System.Runtime.CompilerServices;

public static class Program
{
    static void Main()
    {
        System.Console.WriteLine("Enter Your name:");
        string playername = Console.ReadLine()!;
        IPlayable player = new Player(playername);
        Console.Clear();
        System.Console.WriteLine("Enter Amount to gamble with:");
        int money = Convert.ToInt32(Console.ReadLine()!);
        Console.Clear();
        List<IPlayable> playerlist = new List<IPlayable>();
        IPlayable bot1 = new Bot("barld", 5000);
        IPlayable bot2 = new Bot("kim", 5000);
        IPlayable bot3 = new Bot("annette", 5000);
        playerlist.Add(player);
        playerlist.Add(bot1);
        playerlist.Add(bot2);
        playerlist.Add(bot3);
        GameManager.StartGame(playerlist);
    }
}