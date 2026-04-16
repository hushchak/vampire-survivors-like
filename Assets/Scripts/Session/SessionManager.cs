using System;
using UnityEngine;

public class SessionManager : Singleton<SessionManager>
{
    [SerializeField] private EventChannelCharacterData characterChoosedChannel;

    private CharacterData currentCharacterData;

    private void OnEnable()
    {
        characterChoosedChannel.Subscribe(UpdateCurrentCharacterData);
    }

    private void OnDisable()
    {
        characterChoosedChannel.Unsubscribe(UpdateCurrentCharacterData);
    }

    public async void LoadLobbyScene()
    {
        GameData data = SaveManager.GetGameData();

        PauseManager.Instance.SetPause(false);

        await SceneLoader.LoadScene(
            SceneList.Slots.Session,
            SceneList.Names.Lobby,
            new LobbySceneArgs(data.UnlockedCharacters),
            true
        );
    }

    public async void LoadRunScene(LevelData levelData)
    {
        PauseManager.Instance.SetPause(false);

        await SceneLoader.LoadScene(
            SceneList.Slots.Session,
            SceneList.Names.Run,
            new RunSceneArgs(levelData, currentCharacterData),
            true
        );
    }

    private void UpdateCurrentCharacterData(CharacterData data)
    {
        currentCharacterData = data;
    }
}
