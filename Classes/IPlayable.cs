public interface IPlayable
{
    string Name { get; set; }
    int Buy_in { get; set; }
    bool Folded { get; set; }
    List<Card> cards { get; set; }

    public int Bet(int amount);
}