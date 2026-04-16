public class RunSceneArgs : SceneArgs
{
    public LevelData LevelData { get; private set; }
    public CharacterData CharacterData { get; private set; }

    public RunSceneArgs(LevelData levelData, CharacterData characterData)
    {
        LevelData = levelData;
        CharacterData = characterData;
    }
}
