namespace LudoSim;

public class Player
{
    public Color Color  { get; set; }
    public List<Piece> Pieces = new List<Piece>();
    public List<Piece> MovablePieces = new List<Piece>();
    public Strategy Strategy  { get; set; }
    public Board Board { get; set; }

    public Player(Color color, Strategy strategy, Board board)
    {
        Color = color;
        Strategy = strategy;
        Pieces = new List<Piece>();
        Board = board;
        this.MakePieces();
    }

    public void UnlockPiece()
    {
        Piece toUnlock = Pieces[0];
        toUnlock.CurrentSpace = Board.GetStartingSpace(this.Color);
        MovablePieces.Add(toUnlock);
        Pieces.Remove(toUnlock);
    }

    public void MakePieces()
    {
        for (int i = 0; i < 4; i++)
        {
            Piece toAdd = new Piece();
            toAdd.Color = this.Color;
            Pieces.Add(toAdd);
        }
    }

    public bool HasMovablePieces()
    {
        return MovablePieces.Count > 0;
    }

    public List<List<Move>> GeneratePossibleMoves(List<int> rolls)
    {
        List<List<Move>> ListOfMoves = new List<List<Move>>();
        foreach (var roll in rolls)
        {
            if (ListOfMoves.Count == 0)
            {
                foreach (var piece in MovablePieces)
                {
                    List<Move> moves = new List<Move>();
                    ListOfMoves.Add(moves);
                    List<Space> possibleSpaces = piece.GetEndSpace(piece.CurrentSpace, roll);
                    int index = 5;
                    if (possibleSpaces.Count > 1)
                    {
                        foreach (var space in possibleSpaces)
                        {
                            if (space.Color != this.Color && space.IsFinishSpace)
                            {
                                index = possibleSpaces.IndexOf(space);
                                break;
                            }

                            if (space.Color == this.Color && !space.IsFinishSpace)
                            {
                                index = possibleSpaces.IndexOf(space);
                                break;
                            }
                        }
                        possibleSpaces.RemoveAt(index);
                    }

                    if (possibleSpaces.Count > 1)
                    {
                        throw new Exception("You messed up the thing");
                    }

                    Space spaceToMove = possibleSpaces[0];
                    if (spaceToMove.SpaceIsFull(this.Color))
                    {
                        continue;
                    }

                    Move pieceMove = new Move(piece.CurrentSpace, possibleSpaces[0],
                        spaceToMove.HasOpponentOccupants(this.Color), piece, roll);
                    moves.Add(pieceMove);

                }

                if (roll == 6 && Pieces.Count != 0)
                {
                    Move UnlockMove = new Move(null, Board.GetStartingSpace(Color), false, Pieces[0], roll);
                    List<Move> moves = new List<Move>();
                    moves.Add(UnlockMove);
                    ListOfMoves.Add(moves);
                }
            }
            else
            {
                List<List<Move>> movelistsToAdd = new List<List<Move>>();
                foreach (var list in ListOfMoves)
                {
                    int unlocks = list.Count(x => x.UnlockPiece);
                    List<Piece> pieces = new  List<Piece>();
                    foreach (var piece in MovablePieces)
                    {
                        pieces.Add(piece);
                    }
                    foreach (var move in list)
                    {
                        if (move.UnlockPiece && !MovablePieces.Contains(move.Piece))
                        {
                            pieces.Add(move.Piece);
                        }
                    }
                    foreach (var piece in pieces)
                    {
                        List<Move> moves = list.ToList();
                        movelistsToAdd.Add(moves);
                        Space spaceForMoves = piece.CurrentSpace;
                        if (piece.Equals(list.Last().Piece))
                        {
                            spaceForMoves = list.Last().EndSpace;
                        }
                        List<Space> possibleSpaces = piece.GetEndSpace(spaceForMoves, roll);
                        int index = 5;
                        if (possibleSpaces.Count > 1)
                        {
                            foreach (var space in possibleSpaces)
                            {
                                if (space.Color != this.Color && space.IsFinishSpace)
                                {
                                    index = possibleSpaces.IndexOf(space);
                                    break;
                                }

                                if (space.Color == this.Color && !space.IsFinishSpace)
                                {
                                    index = possibleSpaces.IndexOf(space);
                                    break;
                                }
                            }
                            possibleSpaces.RemoveAt(index);
                        }

                        if (possibleSpaces.Count > 1)
                        {
                            throw new Exception("You messed up the thing");
                        }

                        Space spaceToMove = possibleSpaces[0];
                        if (spaceToMove.SpaceIsFull(this.Color))
                        {
                            continue;
                        }

                        Move pieceMove = new Move(spaceForMoves, possibleSpaces[0],
                            spaceToMove.HasOpponentOccupants(this.Color), piece, roll);
                        moves.Add(pieceMove);

                    }
                    
                    if (roll == 6 && Pieces.Count - unlocks > 0)
                    {
                        Move UnlockMove = new Move(null, Board.GetStartingSpace(Color), false, Pieces[0 + unlocks], roll);
                        List<Move> moves = list.ToList();
                        moves.Add(UnlockMove);
                        movelistsToAdd.Add(moves);
                    }
                }

                foreach (var list in movelistsToAdd)
                {
                    ListOfMoves.Add(list);
                }
            }

        }

        for (int i = ListOfMoves.Count - 1; i > -1; i--)
        {
            if (ListOfMoves[i].Count < rolls.Count)
            {
                ListOfMoves.RemoveAt(i);
            }
        }
        return ListOfMoves;
    }
}