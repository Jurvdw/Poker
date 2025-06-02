public class Player : IPlayable
{
    public string Name { get; set; }
    public int Balance;
    public int Buy_in { get; set; }
    public bool Folded { get; set; }
    public List<Card> cards { get; set; }

    public Player(string name)
    {
        Balance = 5000;
        Buy_in = Balance;
        Name = name;
    }

    public int Bet(int amount)
    {
        // bettingmenu
        Buy_in = -amount;
        int betamount = 100;
        return betamount;
    }
}