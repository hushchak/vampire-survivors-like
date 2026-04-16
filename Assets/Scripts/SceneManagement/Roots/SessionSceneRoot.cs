using System;
using UnityEngine;

public class SessionSceneRoot : SceneRoot
{
    [SerializeField] private CharacterChoosable knightPrefab;
    [SerializeField] private CharacterChoosable wizardPrefab;
    [SerializeField] private CharacterChoosable archerPrefab;

    public async override void Initialize(SceneArgs args)
    {
        GameData data = SaveManager.GetGameData();

        await SceneLoader.LoadScene(SceneList.Slots.Session, SceneList.Names.Lobby, SceneArgs.Empty, true);
        InitializeLobby(data);
    }

    private void InitializeLobby(GameData data)
    {
        if (data.UnlockedCharacters.HasFlag(GameData.Characters.Knight))
            Instantiate(knightPrefab);
        if (data.UnlockedCharacters.HasFlag(GameData.Characters.Wizard))
            Instantiate(wizardPrefab);
        if (data.UnlockedCharacters.HasFlag(GameData.Characters.Archer))
            Instantiate(archerPrefab);
    }
}
