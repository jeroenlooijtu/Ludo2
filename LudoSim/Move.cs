namespace LudoSim;

public class Move
{
    public Space? StartSpace { get; set; }
    public Space EndSpace { get; set; }
    public bool TakesPiece { get; set; }
    public bool UnlockPiece { get; set; }
    public int Spaces { get; set; }
    
    public Piece Piece { get; set; }

    public Move(Space StartSpace, Space EndSpace, bool TakesPiece, Piece  Piece, int spaces )
    {
        this.StartSpace = StartSpace;
        this.EndSpace = EndSpace;
        this.TakesPiece = TakesPiece;
        this.UnlockPiece = StartSpace == null;
        this.Piece = Piece;
        this.Spaces = spaces;
    }

    public override string ToString()
    {
        String toret = "";
        if (UnlockPiece)
        {
            toret += "Unlocking a piece ";
        }
        else
        {
            toret += "Moving a piece from " + StartSpace?.Name + " to " + EndSpace.Name + " Moving " + Spaces + " spaces forward";
        }

        if (EndSpace.IsFinishSpace)
        {
            toret += " And the piece has now finished";
        }
        return toret;
    }
}