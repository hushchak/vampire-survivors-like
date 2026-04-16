public class GameData
{
    [System.Flags]
    public enum Characters
    {
        Knight = 0,
        Wizard = 1 << 0,  // 1
        Archer = 1 << 1   // 2
    }

    [System.Flags]
    public enum Levels
    {
        Level1 = 0,
        Level2 = 1 << 0, // 1
        Level3 = 1 << 1  // 2
    }

    public Characters UnlockedCharacters;
    public Levels UnlockedLevels;

    public GameData()
    {
        UnlockedCharacters = 0;
        UnlockedLevels = 0;
    }
}
