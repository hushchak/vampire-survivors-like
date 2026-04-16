using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class CharacterChoosable : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private LobbyCharacter lobbyCharacterPrefab;
    [SerializeField] private CharacterData characterData;
    [SerializeField] private EventChannelCharacterData characterChoosenChannel;

    private void Awake()
    {
        characterChoosenChannel.Subscribe(UpdateActive);
    }

    private void OnDestroy()
    {
        characterChoosenChannel.Unsubscribe(UpdateActive);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        characterChoosenChannel.Raise(characterData);

        LobbyCharacter character = Instantiate(lobbyCharacterPrefab, transform.position, Quaternion.identity);
        character.Setup(characterData);

        gameObject.SetActive(false);
    }

    private void UpdateActive(CharacterData _)
    {
        if (gameObject.activeSelf == false)
            gameObject.SetActive(true);
    }
}
