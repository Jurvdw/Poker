public class Player : IPlayable
{
    public string Name { get; set; }
    public int Balance;
    public int Buy_in { get; set; }
    public bool Folded { get; set; }

    public Player(string name)
    {
        Balance = 5000;
        Buy_in = Balance;
        Name = name;
    }

    public void Bet(int amount)
    {
        Buy_in = -amount;
    }
}