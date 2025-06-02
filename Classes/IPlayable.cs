public interface IPlayable
{
    string Name { get; set; }
    int Buy_in { get; set; }
    bool Folded { get; set; }

    public void Bet(int amount);
}