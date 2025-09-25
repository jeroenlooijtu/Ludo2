using LudoSim;

namespace TestProject1;

public abstract class LudoTestBase : IDisposable
{
    
    public Player PlayerRed { get; set; }
    public Player PlayerBlue { get; set; }
    public Player PlayerYellow { get; set; }
    public Player PlayerPurple { get; set; }
    public Game Game  { get; set; }
    public Board Board { get; set; }
    public Space Space1  { get; set; }
    public Space Space2  { get; set; }
    public Space Space3  { get; set; }
    public Space Space4  { get; set; }
    public Space Space5  { get; set; }
    public Space Space6  { get; set; }
    public Space Space7  { get; set; }
    public Space Space8  { get; set; }
    public Space Space9  { get; set; }
    public Space Space11  { get; set; }
    public Space Space12  { get; set; }
    public Space Space13  { get; set; }
    public Space Space14  { get; set; }
    public Space Space15  { get; set; }
    public Space Space16  { get; set; }
    public Space Space17  { get; set; }
    public Space Space18  { get; set; }
    public Space Space19  { get; set; }
    public Space Space21  { get; set; }
    public Space Space22  { get; set; }
    public Space Space23  { get; set; }
    public Space Space24  { get; set; }
    public Space Space25  { get; set; }
    public Space Space26  { get; set; }
    public Space Space27  { get; set; }
    public Space Space28  { get; set; }
    public Space Space29  { get; set; }
    public Space Space31  { get; set; }
    public Space Space32  { get; set; }
    public Space Space33  { get; set; }
    public Space Space34  { get; set; }
    public Space Space35  { get; set; }
    public Space Space36  { get; set; }
    public Space Space37  { get; set; }
    public Space Space38  { get; set; }
    public Space Space39  { get; set; }
    public Space SafeSpaceRed  { get; set; }
    public Space SafeSpaceYellow   { get; set; }
    public Space SafeSpaceGreen   { get; set; }
    public Space SafeSpaceBlue {get; set; }
    public Space FinishSpaceRed1 { get; set; }
    public Space FinishSpaceRed2 { get; set; }
    public Space FinishSpaceRed3 { get; set; }
    public Space FinishSpaceRed4 { get; set; }
    public Space FinishSpaceBlue1 { get; set; }
    public Space FinishSpaceBlue2 { get; set; }
    public Space FinishSpaceBlue3 { get; set; }
    public Space FinishSpaceBlue4 { get; set; }
    public Space FinishSpaceYellow1 { get; set; }
    public Space FinishSpaceYellow2 { get; set; }
    public Space FinishSpaceYellow3 { get; set; }
    public Space FinishSpaceYellow4 { get; set; }
    public Space FinishSpacePurple1 { get; set; }
    public Space FinishSpacePurple2 { get; set; }
    public Space FinishSpacePurple3 { get; set; }
    public Space FinishSpacePurple4 { get; set; }
    protected LudoTestBase()
    {
        SafeSpaceRed = new Space
        {
            Name = "Red Starting Space",
            Color = Color.Red,
            IsFinishSpace = false,
            IsSafe = true
        };
        Space1 = new Space
        {
            Name = "Line 1 Space 1",
            Color = Color.None,
            IsFinishSpace = false,
            IsSafe = false
        };
        SafeSpaceRed.Spaces.Add(Space1);
        Space2 = new Space
        {
            Name = "Line 1 Space 2",
            Color = Color.None,
            IsFinishSpace = false,
            IsSafe = false
        };
        Space1.Spaces.Add(Space2);
        Space3 = new Space
        {
            Name = "Line 1 Space 3",
            Color = Color.None,
            IsFinishSpace = false,
            IsSafe = false
        };
        Space2.Spaces.Add(Space3);
        Space4 = new Space
        {
            Name = "Line 1 Space 4",
            Color = Color.None,
            IsFinishSpace = false,
            IsSafe = false
        };
        Space3.Spaces.Add(Space4);
        Space5 = new Space
        {
            Name = "Line 1 Space 5",
            Color = Color.None,
            IsFinishSpace = false,
            IsSafe = false
        };
        Space4.Spaces.Add(Space5);
        Space6 = new Space
        {
            Name = "Line 1 Space 6",
            Color = Color.None,
            IsFinishSpace = false,
            IsSafe = false
        };
        Space5.Spaces.Add(Space6);
        Space7 = new Space
        {
            Name = "Line 1 Space 7",
            Color = Color.None,
            IsFinishSpace = false,
            IsSafe = false
        };
        Space6.Spaces.Add(Space7);
        Space8 = new Space
        {            
            Name = "Line 1 Space 8",
            Color = Color.None,
            IsFinishSpace = false,
            IsSafe = false
        };
        Space7.Spaces.Add(Space8);
        Space9 = new Space
        {
            Name = "Line 1 Space 9",
            Color = Color.None,
            IsFinishSpace = false,
            IsSafe = false
        };
        Space8.Spaces.Add(Space9);
        SafeSpaceBlue = new Space
        {
            Name = "Blue starting space",
            Color = Color.Blue,
            IsFinishSpace = false,
            IsSafe = true
        };
        Space9.Spaces.Add(SafeSpaceBlue);
        Space11 = new Space
        {
            Name = "Line 2 Space 1",
            Color = Color.None,
            IsFinishSpace = false,
            IsSafe = false
        };
        SafeSpaceBlue.Spaces.Add(Space11);
        Space12 = new Space
        {
            Name = "Line 2 Space 2",
            Color = Color.None,
            IsFinishSpace = false,
            IsSafe = false
        };
        Space11.Spaces.Add(Space12);
        Space13 = new Space
        {
            Name = "Line 2 Space 3",
            Color = Color.None,
            IsFinishSpace = false,
            IsSafe = false
        };
        Space12.Spaces.Add(Space13);
        Space14 = new Space
        {
            Name = "Line 2 Space 4",
            Color = Color.None,
            IsFinishSpace = false,
            IsSafe = false
        };
        Space13.Spaces.Add(Space14);
        Space15 = new Space
        {
            Name = "Line 2 Space 5",
            Color = Color.None,
            IsFinishSpace = false,
            IsSafe = false
        };
        Space14.Spaces.Add(Space15);
        Space16 = new Space
        {
            Name = "Line 2 Space 6",
            Color = Color.None,
            IsFinishSpace = false,
            IsSafe = false
        };
        Space15.Spaces.Add(Space16);
        Space17 = new Space
        {
            Name = "Line 2 Space 7",
            Color = Color.None,
            IsFinishSpace = false,
            IsSafe = false
        };
        Space16.Spaces.Add(Space17);
        Space18 = new Space
        {
            Name = "Line 2 Space 8",
            Color = Color.None,
            IsFinishSpace = false,
            IsSafe = false
        };
        Space17.Spaces.Add(Space18);
        Space19 = new Space
        {
            Name = "Line 2 Space 9",
            Color = Color.None,
            IsFinishSpace = false,
            IsSafe = false
        };
        Space18.Spaces.Add(Space19);
        SafeSpaceYellow = new Space
        {
            Name = "Yellow starting space",
            Color = Color.Yellow,
            IsFinishSpace = false,
            IsSafe = true
        };
        Space19.Spaces.Add(SafeSpaceYellow);
        Space21 = new Space
        {
            Name = "Line 3 Space 1",
            Color = Color.None,
            IsFinishSpace = false,
            IsSafe = false
        };
        SafeSpaceYellow.Spaces.Add(Space21);
        Space22 = new Space
        {
            Name = "Line 3 Space 2",
            Color = Color.None,
            IsFinishSpace = false,
            IsSafe = false
        };
        Space21.Spaces.Add(Space22);
        Space23 = new Space
        {
            Name = "Line 3 Space 3",
            Color = Color.None,
            IsFinishSpace = false,
            IsSafe = false
        };
        Space22.Spaces.Add(Space23);
        Space24 = new Space
        {
            Name = "Line 3 Space 4",
            Color = Color.None,
            IsFinishSpace = false,
            IsSafe = false
        };
        Space23.Spaces.Add(Space24);
        Space25 = new Space
        {
            Name = "Line 3 Space 5",
            Color = Color.None,
            IsFinishSpace = false,
            IsSafe = false
        };
        Space24.Spaces.Add(Space25);
        Space26 = new Space
        {
            Name = "Line 3 Space 6",
            Color = Color.None,
            IsFinishSpace = false,
            IsSafe = false
        };
        Space25.Spaces.Add(Space26);
        Space27 = new Space
        {
            Name = "Line 3 Space 7",
            Color = Color.None,
            IsFinishSpace = false,
            IsSafe = false
        };
        Space26.Spaces.Add(Space27);
        Space28 = new Space
        {
            Name = "Line 3 Space 8",
            Color = Color.None,
            IsFinishSpace = false,
            IsSafe = false
        };
        Space27.Spaces.Add(Space28);
        Space29 = new Space
        {
            Name = "Line 3 Space 9",
            Color = Color.None,
            IsFinishSpace = false,
            IsSafe = false
        };
        Space28.Spaces.Add(Space29);
        var safeSpacePurple = new Space
        {
            Name = "Purple starting space",
            Color = Color.Purple,
            IsFinishSpace = false,
            IsSafe = true
        };
        Space29.Spaces.Add(safeSpacePurple);
        Space31 = new Space
        {
            Name = "Line 4 Space 1",
            Color = Color.None,
            IsFinishSpace = false,
            IsSafe = false
        };
        safeSpacePurple.Spaces.Add(Space31);
        Space32 = new Space
        {
            Name = "Line 4 Space 2",
            Color = Color.None,
            IsFinishSpace = false,
            IsSafe = false
        };
        Space31.Spaces.Add(Space32);
        Space33 = new Space
        {
            Name = "Line 4 Space 3",
            Color = Color.None,
            IsFinishSpace = false,
            IsSafe = false
        };
        Space32.Spaces.Add(Space33);
        Space34 = new Space
        {
            Name = "Line 4 Space 4",
            Color = Color.None,
            IsFinishSpace = false,
            IsSafe = false
        };
        Space33.Spaces.Add(Space34);
        Space35 = new Space
        {
            Name = "Line 4 Space 5",
            Color = Color.None,
            IsFinishSpace = false,
            IsSafe = false
        };
        Space34.Spaces.Add(Space35);
        Space36 = new Space
        {
            Name = "Line 4 Space 6",
            Color = Color.None,
            IsFinishSpace = false,
            IsSafe = false
        };
        Space35.Spaces.Add(Space36);
        Space37 = new Space
        {
            Name = "Line 4 Space 7",
            Color = Color.None,
            IsFinishSpace = false,
            IsSafe = false
        };
        Space36.Spaces.Add(Space37);
        Space38 = new Space
        {
            Name = "Line 4 Space 8",
            Color = Color.None,
            IsFinishSpace = false,
            IsSafe = false
        };
        Space37.Spaces.Add(Space38);
        Space39 = new Space
        {
            Name = "Line 4 Space 9",
            Color = Color.None,
            IsFinishSpace = false,
            IsSafe = false
        };
        Space38.Spaces.Add(Space39);
        Space39.Spaces.Add(SafeSpaceRed);
        FinishSpaceRed1 = new Space
        {
            Name = "Red finish space 1",
            Color = Color.Red,
            IsFinishSpace = true,
            IsSafe = true
        };
        Space39.Spaces.Add(FinishSpaceRed1);
        FinishSpaceRed2 = new Space
        {
            Name = "Red finish space 2",
            Color = Color.Red,
            IsFinishSpace = true,
            IsSafe = true
        };
        FinishSpaceRed3 = new Space
        {
            Name = "Red finish space 3",
            Color = Color.Red,
            IsFinishSpace = true,
            IsSafe = true
        };
        FinishSpaceRed4 = new Space
        {
            Name = "Red finish space 4",
            Color = Color.Red,
            IsFinishSpace = true,
            IsSafe = true
        };
        FinishSpaceRed1.Spaces.Add(FinishSpaceRed2);
        FinishSpaceRed2.Spaces.Add(FinishSpaceRed3);
        FinishSpaceRed3.Spaces.Add(FinishSpaceRed4);
        FinishSpaceBlue1 = new Space
        {
            Name = "Blue finish space 1",
            Color = Color.Blue,
            IsFinishSpace = true,
            IsSafe = true
        };
        FinishSpaceBlue2 = new Space
        {
            Name = "Blue finish space 2",
            Color = Color.Blue,
            IsFinishSpace = true,
            IsSafe = true
        };
        FinishSpaceBlue3 = new Space
        {
            Name = "Blue finish space 3",
            Color = Color.Blue,
            IsFinishSpace = true,
            IsSafe = true
        };
        FinishSpaceBlue4 = new Space
        {
            Name = "Blue finish space 4",
            Color = Color.Blue,
            IsFinishSpace = true,
            IsSafe = true
        };
        Space9.Spaces.Add(FinishSpaceBlue1);
        FinishSpaceBlue1.Spaces.Add(FinishSpaceBlue2);
        FinishSpaceBlue2.Spaces.Add(FinishSpaceBlue3);
        FinishSpaceBlue3.Spaces.Add(FinishSpaceBlue4);
        FinishSpaceYellow1 = new Space
        {
            Name = "Yellow finish space 1",
            Color = Color.Yellow,
            IsFinishSpace = true,
            IsSafe = true
        };
        FinishSpaceYellow2 = new Space
        {
            Name = "Yellow finish space 2",
            Color = Color.Yellow,
            IsFinishSpace = true,
            IsSafe = true
        };
        FinishSpaceYellow3 = new Space
        {
            Name = "Yellow finish space 3",
            Color = Color.Yellow,
            IsFinishSpace = true,
            IsSafe = true
        };
        FinishSpaceYellow4 = new Space
        {
            Name = "Yellow finish space 4",
            Color = Color.Yellow,
            IsFinishSpace = true,
            IsSafe = true
        };
        Space19.Spaces.Add(FinishSpaceYellow1);
        FinishSpaceYellow1.Spaces.Add(FinishSpaceYellow2);
        FinishSpaceYellow2.Spaces.Add(FinishSpaceYellow3);
        FinishSpaceYellow3.Spaces.Add(FinishSpaceYellow4);
        FinishSpacePurple1 = new Space
        {
            Name = "Purple finish space 1",
            Color = Color.Purple,
            IsFinishSpace = true,
            IsSafe = true
        };
        FinishSpacePurple2 = new Space
        {
            Name = "Purple finish space 2",
            Color = Color.Purple,
            IsFinishSpace = true,
            IsSafe = true
        };
        FinishSpacePurple3 = new Space
        {
            Name = "Purple finish space 3",
            Color = Color.Purple,
            IsFinishSpace = true,
            IsSafe = true
        };
        FinishSpacePurple4 = new Space
        {
            Name = "Purple finish space 4",
            Color = Color.Purple,
            IsFinishSpace = true,
            IsSafe = true
        };
        Space29.Spaces.Add(FinishSpacePurple1);
        FinishSpacePurple1.Spaces.Add(FinishSpacePurple2);
        FinishSpacePurple2.Spaces.Add(FinishSpacePurple3);
        FinishSpacePurple3.Spaces.Add(FinishSpacePurple4);

        Board = new Board();
        Board.Spaces.Add(Space1);
        Board.Spaces.Add(Space2);
        Board.Spaces.Add(Space3);
        Board.Spaces.Add(Space4);
        Board.Spaces.Add(Space5);
        Board.Spaces.Add(Space6);
        Board.Spaces.Add(Space7);
        Board.Spaces.Add(Space8);
        Board.Spaces.Add(Space9);
        Board.Spaces.Add(Space11);
        Board.Spaces.Add(Space12);
        Board.Spaces.Add(Space13);
        Board.Spaces.Add(Space14);
        Board.Spaces.Add(Space15);
        Board.Spaces.Add(Space16);
        Board.Spaces.Add(Space17);
        Board.Spaces.Add(Space18);
        Board.Spaces.Add(Space19);
        Board.Spaces.Add(Space21);
        Board.Spaces.Add(Space22);
        Board.Spaces.Add(Space23);
        Board.Spaces.Add(Space24);
        Board.Spaces.Add(Space25);
        Board.Spaces.Add(Space26);
        Board.Spaces.Add(Space27);
        Board.Spaces.Add(Space28);
        Board.Spaces.Add(Space29);
        Board.Spaces.Add(Space31);
        Board.Spaces.Add(Space32);
        Board.Spaces.Add(Space33);
        Board.Spaces.Add(Space34);
        Board.Spaces.Add(Space35);
        Board.Spaces.Add(Space36);
        Board.Spaces.Add(Space37);
        Board.Spaces.Add(Space38);
        Board.Spaces.Add(Space39);
        Board.Spaces.Add(SafeSpaceRed);
        Board.Spaces.Add(SafeSpaceBlue);
        Board.Spaces.Add(safeSpacePurple);
        Board.Spaces.Add(SafeSpaceYellow);
        Board.Spaces.Add(FinishSpaceRed1);
        Board.Spaces.Add(FinishSpaceRed2);
        Board.Spaces.Add(FinishSpaceRed3);
        Board.Spaces.Add(FinishSpaceRed4);
        Board.Spaces.Add(FinishSpaceBlue1);
        Board.Spaces.Add(FinishSpaceBlue2);
        Board.Spaces.Add(FinishSpaceBlue3);
        Board.Spaces.Add(FinishSpaceBlue4);
        Board.Spaces.Add(FinishSpaceYellow1);
        Board.Spaces.Add(FinishSpaceYellow2);
        Board.Spaces.Add(FinishSpaceYellow3);
        Board.Spaces.Add(FinishSpaceYellow4);
        Board.Spaces.Add(FinishSpacePurple1);
        Board.Spaces.Add(FinishSpacePurple2);
        Board.Spaces.Add(FinishSpacePurple3);
        Board.Spaces.Add(FinishSpacePurple4);
        PlayerRed = new Player(Color.Red, new SafeStrategy(), Board);
        PlayerBlue  = new Player(Color.Blue, new SafeStrategy(), Board);
        PlayerPurple = new Player(Color.Purple, new SafeStrategy(), Board);
        PlayerYellow = new Player(Color.Yellow, new SafeStrategy(), Board);

        Game game = new Game(Board);
        game.Players.Add(PlayerRed);
        PlayerRed.UnlockPiece();
    }

    public void Dispose()
    {
        // TODO release managed resources here
    }
}