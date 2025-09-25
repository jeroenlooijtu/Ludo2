namespace LudoSim;

public class Space
{
    public Color Color {get; set;}
    public String Name {get; set;}
    public bool IsSafe {get; set;}
    public bool IsFinishSpace {get; set;}
    public List<Space>  Spaces = new List<Space>();
    public List<Piece> Occupants = new List<Piece>();

    public bool HasOpponentOccupants(Color color)
    {
        if (IsSafe)
        {
            return false;
        }
        foreach (var piece in Occupants)
        {
            if (piece.Color != color)
            {
                return true;
            }
        }
        return false;
    }

    public bool SpaceIsFull(Color color)
    {
        if (!IsFinishSpace)
        {
            return Occupants.Count > 0 && Occupants[0].Color == color;
        }

        return false;
    }
}