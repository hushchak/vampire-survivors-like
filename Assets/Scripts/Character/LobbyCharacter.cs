using System;
using UnityEngine;

public class LobbyCharacter : MonoBehaviour
{
    [SerializeField] private CharacterMovement movement;
    [Space]
    [SerializeField] private EventChannel characterChoosedChannel;

    public void Setup(CharacterData data)
    {
        characterChoosedChannel.Subscribe(DestroySelf);
        movement.Setup(data);
    }

    private void DestroySelf()
    {
        Destroy(gameObject);
    }

    private void OnDestroy()
    {
        characterChoosedChannel.Unsubscribe(DestroySelf);
    }
}
