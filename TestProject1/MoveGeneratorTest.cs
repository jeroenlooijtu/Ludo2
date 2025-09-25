using LudoSim;

namespace TestProject1;

public class MoveGeneratorTest : LudoTestBase
{

    [Fact]
    public void MoveTestOneNumber()
    {
        //Arrange
        List<int> rolls = new List<int>(){5};
        List<List<Move>> expectedMoves = new List<List<Move>>();
        List<Move> actualMoves = new List<Move>();
        Move move = new Move(Board.GetStartingSpace(PlayerRed.Color), Space5, false, PlayerRed.MovablePieces[0], rolls[0]);
        actualMoves.Add(move);
        expectedMoves.Add(actualMoves);
        //Act
        List<List<Move>> moves = PlayerRed.GeneratePossibleMoves(rolls);
        //Assert
        Assert.Equivalent(expectedMoves, moves);
        
        
    }

    [Fact]
    public void MoveTestTwoNumbers()
    {
        //Arrange
        List<int> rolls = new List<int>(){6, 4};
        List<List<Move>> expectedMoves = new List<List<Move>>();
        List<Move> actualMoves = new List<Move>();
        List<Move> actualMoves1 = new List<Move>();
        List<Move> actualMoves2 = new List<Move>();
        Move move = new Move(null, Board.GetStartingSpace(PlayerRed.Color), false, PlayerRed.Pieces[1], rolls[0]);
        Move move2 = new Move(Board.GetStartingSpace(PlayerRed.Color), Space4, false, PlayerRed.Pieces[1], rolls[1]);
        Move move3 = new Move(Board.GetStartingSpace(PlayerRed.Color), Space4, false, PlayerRed.MovablePieces[0], rolls[1]);
        Move move4 = new Move(Board.GetStartingSpace(PlayerRed.Color), Space6, false, PlayerRed.MovablePieces[0], rolls[0]);
        Move move5 = new Move(Space6, SafeSpaceBlue, false, PlayerRed.MovablePieces[0], rolls[1]);
        actualMoves.Add(move);
        actualMoves.Add(move2);
        actualMoves1.Add(move);
        actualMoves1.Add(move3);
        actualMoves2.Add(move4);
        actualMoves2.Add(move5);
        expectedMoves.Add(actualMoves);
        expectedMoves.Add(actualMoves1);
        expectedMoves.Add(actualMoves2);
        //Act
        List<List<Move>> moves = PlayerRed.GeneratePossibleMoves(rolls);
        //Assert
        Assert.Equivalent(expectedMoves, moves);
    }
    
}