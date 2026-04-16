public class LobbySceneArgs : SceneArgs
{
    public GameData.Characters UnlockedCharacters { get; private set; }

    public LobbySceneArgs(GameData.Characters unlockedCharacters)
    {
        UnlockedCharacters = unlockedCharacters;
    }
}
