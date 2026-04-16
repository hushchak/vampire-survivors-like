using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "EventChannels/EventChannel CharacterData", fileName = "EventChannelCharacterData")]
public class EventChannelCharacterData : ScriptableObject
{
    private List<Action<CharacterData>> actions = new();

    public void Subscribe(Action<CharacterData> action) => actions.Add(action);
    public void Unsubscribe(Action<CharacterData> action) => actions.Remove(action);

    public void Raise(CharacterData data)
    {
        foreach (Action<CharacterData> actions in actions)
        {
            actions?.Invoke(data);
        }
    }
}
