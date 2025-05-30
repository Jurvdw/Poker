using System.Runtime.CompilerServices;

public class Program
{
    static void Main()
    {
        List<Card> cards = CreateDeck();
        System.Console.WriteLine("Enter Your name:");
        string playername = Console.ReadLine()!;
        Player player = new Player(playername);
        Console.Clear();
        System.Console.WriteLine("Enter Amount to gamble with:");
        int money = Convert.ToInt32(Console.ReadLine()!);
        Console.Clear();
    }


    static List<Card> CreateDeck()
    {
        List<Card> cards = new List<Card>();
        Dictionary<int, string> suits = new Dictionary<int, string>
        {
            { 1, "Hearts" },
            { 2, "Diamonds" },
            { 3, "Clubs" },
            { 4, "Spades" }
        };
        string[] values = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };

        for (int suitId = 1; suitId <= 4; suitId++)
        {
            foreach (string value in values)
            {
                Card card = new Card(
                    suits[suitId],
                    value,
                    new List<int> { suitId, Array.IndexOf(values, value) + 1 }
                );
                cards.Add(card);
            }
        }

        return cards;
    }
}