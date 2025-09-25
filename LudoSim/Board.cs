namespace LudoSim;

public class Board
{
    public List<Space> Spaces = new List<Space>();

    public Space GetStartingSpace(Color color)
    {
        switch (color)
        {
         case Color.Red:
             return Spaces.FirstOrDefault(s => s.Color == Color.Red && s.IsSafe == true && s.IsFinishSpace == false);
         case Color.Blue:
             return Spaces.FirstOrDefault(s => s.Color == Color.Blue && s.IsSafe == true && s.IsFinishSpace == false);
         case Color.Yellow:
             return Spaces.FirstOrDefault(s => s.Color == Color.Yellow && s.IsSafe == true && s.IsFinishSpace == false);
         case Color.Purple:
             return Spaces.FirstOrDefault(s => s.Color == Color.Purple && s.IsSafe == true && s.IsFinishSpace == false);
        }
        throw new NotImplementedException("This ones messed up too idiot");
    }


    
}