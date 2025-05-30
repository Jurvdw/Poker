public class Bot : IPlayable
{
    public string Name { get; set; }
    public int Buy_in { get; set; }

    public Bot(string name, int buy_in)
    {
        Name = name;
        Buy_in = buy_in;
    }
}