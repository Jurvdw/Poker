public class Bot : IPlayable
{
    public string Name { get; set; }
    public int Buy_in { get; set; }
    public bool Folded { get; set; }
    public List<Card> cards { get; set; }

    public Bot(string name, int buy_in)
    {
        Name = name;
        Buy_in = buy_in;
    }

    public int Bet(int amount)
    {
        int betamount = 100;
        Buy_in = Buy_in - betamount;
        return betamount;
    }
}