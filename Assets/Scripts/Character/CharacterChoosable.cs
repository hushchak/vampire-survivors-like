using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class CharacterChoosable : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private LobbyCharacter lobbyCharacterPrefab;
    [SerializeField] private CharacterData characterData;
    [SerializeField] private EventChannel characterChoosedChannel;

    private void Awake()
    {
        characterChoosedChannel.Subscribe(UpdateActive);
    }

    private void OnDestroy()
    {
        characterChoosedChannel.Unsubscribe(UpdateActive);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        characterChoosedChannel.Raise();

        LobbyCharacter character = Instantiate(lobbyCharacterPrefab, transform.position, Quaternion.identity);
        character.Setup(characterData);

        gameObject.SetActive(false);
    }

    private void UpdateActive()
    {
        if (gameObject.activeSelf == false)
            gameObject.SetActive(true);
    }
}
