public class Table
{
    public List<Player> players = new List<Player>();
    public int pot;
    public List<Card> deck = new List<Card>();
    public List<Card> Active = new List<Card>();

    public Table(List<Player> playerslist)
    {
        players = playerslist;
    }
}