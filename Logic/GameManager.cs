using System.Net;

static class GameManager
{
    private static bool _isGameActive = false;

    public static void StartGame(List<IPlayable> players)
    {
        Table.players = players;
        // betting pre-flop
        // show 3 cards
        // betting round
        // another card
        // last card
        // last round
        // process results
    }
}
