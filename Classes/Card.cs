public class Card
{
    public string suit;
    public string amount;
    public List<int> Hash;

    public Card(string suit, string amount, List<int> hash)
    {
        this.suit = suit;
        this.amount = amount;
        Hash = hash;
    }

    public override string ToString()
    {
        return $"{amount} of {suit} (Hash: [{Hash[0]}, {Hash[1]}])";
    }
}