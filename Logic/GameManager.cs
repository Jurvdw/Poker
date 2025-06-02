using System.Net;

static class GameManager
{
    private static bool _isGameActive = false;

    public static void StartGame(List<IPlayable> players)
    {
        Table.players = players;
    }
}
