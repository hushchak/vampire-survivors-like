public class GameData
{
    [System.Flags]
    public enum Characters
    {
        Knight = 0,
        Wizard = 1 << 0,  // 1
        Archer = 1 << 1   // 2
    }

    public Characters UnlockedCharacters;

    public GameData()
    {
        UnlockedCharacters = 0;
    }
}
