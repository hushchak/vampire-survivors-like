using System;
using UnityEngine;

public class LobbySceneRoot : SceneRoot
{
    [SerializeField] private CharacterChoosable knightPrefab;
    [SerializeField] private CharacterChoosable wizardPrefab;
    [SerializeField] private CharacterChoosable archerPrefab;

    public override void Initialize(SceneArgs args)
    {
        if (args.GetType() != typeof(LobbySceneArgs))
        {
            Debug.LogError("You are trying to load Lobby scene with wrong SceneArgs");
            return;
        }

        LobbySceneArgs lobbyArgs = (LobbySceneArgs)args;
        InitializeCharacterChoosables(lobbyArgs.UnlockedCharacters);
    }

    private void InitializeCharacterChoosables(GameData.Characters unlockedCharacters)
    {
        if (unlockedCharacters.HasFlag(GameData.Characters.Knight))
            Instantiate(knightPrefab);
        if (unlockedCharacters.HasFlag(GameData.Characters.Wizard))
            Instantiate(wizardPrefab);
        if (unlockedCharacters.HasFlag(GameData.Characters.Archer))
            Instantiate(archerPrefab);
    }
}
