using System;
using UnityEngine;

public class SessionSceneRoot : SceneRoot
{
    [SerializeField] private SessionManager manager;

    public override void Initialize(SceneArgs args)
    {
        manager.LoadLobbyScene();
    }
}
