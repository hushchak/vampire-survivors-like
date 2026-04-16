using System;
using UnityEngine;

public class LobbyCharacter : MonoBehaviour
{
    [SerializeField] private EventChannelCharacterData characterChoosenChannel;

    CharacterData data;

    public void Setup(CharacterData data)
    {
        this.data = data;
        characterChoosenChannel.Subscribe(DestroySelf);
    }

    private void DestroySelf(CharacterData _)
    {
        Destroy(gameObject);
    }

    private void OnDestroy()
    {
        characterChoosenChannel.Unsubscribe(DestroySelf);
    }

    private void FixedUpdate()
    {
        if (PauseManager.Instance.IsPaused)
            return;

        Vector2 movementOffset = InputReader.InputVector.normalized * data.MovementSpeed * Time.fixedDeltaTime;
        transform.position = (Vector2)transform.position + movementOffset;
    }
}
