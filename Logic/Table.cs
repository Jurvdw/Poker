using System.Data;

public static class Table
{
    public static List<IPlayable> players = new List<IPlayable>();
    public static int pot;
    public static List<Card> deck = CreateDeck();
    public static List<Card> Active = new List<Card>();


    public static void ResetTable()
    {

    }

    public static void DealToPlayers(int Amount)
    {
        foreach (IPlayable player in players)
        {
            if (!player.Folded)
            {
                TakeFromDeck(Amount, player.cards);
            }
        }
    }

    public static void DealCommunityCards(int Amount)
    {

    }

    public static void ShuffleDeck()
    {
        Random rng = new Random();
        int count = deck.Count;

        for (int i = 0; i < count; i++)
        {
            int j = rng.Next(count);
            Card temp = deck[i];
            deck[i] = deck[j];
            deck[j] = temp;
        }
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

    public static void TakeFromDeck(int amount, List<Card> cardlist)
    {
        for (int i = 0; i < amount; i++)
        {
            Random random = new Random();
            int rint = random.Next(0, deck.Count);
            Card chosencard = deck[rint];
            deck.Remove(chosencard);
            cardlist.Add(chosencard);
        }
    }
}