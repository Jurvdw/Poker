public class Player: IPlayable
{
    public string Name { get; set; }
    public int Balance;
    public int Buy_in { get; set; }

    public Player(string name)
    {
        Balance = 5000;
        Name = name;
    }
}