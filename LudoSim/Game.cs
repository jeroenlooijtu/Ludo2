namespace LudoSim;

public class Game
{
    public Board Board;
    public List<Player> Players = new List<Player>();
    public Player CurrentPlayer;

    public Game(Board board)
    {
        Board = board;
    }

    public void AddPlayer(Player player)
    {
        if (Players.Count == 4)
        {
            return;
        }
        foreach (var p in Players)
        {
            if (player.Color == p.Color)
            {
                return;
            }
        }
        Players.Add(player);
    }

    public void startGame()
    {
        if (Players.Count != 4)
        {
            return;
        }
        CurrentPlayer = Players[0];
        while (true)
        {
            List<int> rolls = this.rolls();
            if (CurrentPlayer.HasMovablePieces())
            {
                rolls = this.rolls();
            }
            else
            {
                rolls = UnlockRolls();
            }
            
            
        }
    }

    public List<int> rolls()
    {
        Random rnd = new Random();
        List<int> rolls = new List<int>();
        while (true)
        {
            int roll = rnd.Next(1, 7);
            rolls.Add(roll);
            if (roll != 6) break;
        }

        return rolls;
    }

    public List<int> UnlockRolls()
    {
        int minrolls = 3;
        Random rnd = new Random();
        List<int> rolls = new List<int>();
        while (minrolls != 0)
        {
            int roll = rnd.Next(1, 6);
            if (roll == 6)
            {
                rolls.Add(roll);
                break;
            }
            
            minrolls--;
        }

        if (minrolls != 0)
        {
            while (true)
            {
                int roll = rnd.Next(1, 6);
                rolls.Add(roll);
                if (roll != 6) break;
            }
        }

        return rolls;
    }
}