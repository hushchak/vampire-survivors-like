using System;
using UnityEngine;

public class RunSceneRoot : SceneRoot
{
    [SerializeField] private Character characterPrefab;

    public override void Initialize(SceneArgs args)
    {
        if (args.GetType() != typeof(RunSceneArgs))
        {
            Debug.LogError("You are trying to load Lobby scene with wrong SceneArgs");
            return;
        }

        RunSceneArgs runArgs = (RunSceneArgs)args;
        InitializeCharacter(runArgs.CharacterData);
    }

    private void InitializeCharacter(CharacterData data)
    {
        Character character = Instantiate(characterPrefab, Vector2.zero, Quaternion.identity);
        character.Setup(data);
    }
}
