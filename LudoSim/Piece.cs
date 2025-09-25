namespace LudoSim;

public class Piece
{
    public Color Color {get; set;}
    public Space CurrentSpace {get; set;}

    public List<Space> GetEndSpace(Space startingSpace, int moves)
    {
        if (moves > 1)
        {
            return GetEndSpace(startingSpace.Spaces[0], moves - 1);
        }
        else
        {
            return startingSpace.Spaces;
        }
    }
}