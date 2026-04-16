using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class LobbyDoor : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private EventChannel LobbyDoorTriggeredChannel;
    [SerializeField] private EventChannelCharacterData characterChoosedChannel;

    [SerializeField] private WindowsController windowsController;
    [SerializeField] private Window LevelChooseWindow;

    private bool characterChoosed = false;

    private void OnEnable()
    {
        characterChoosedChannel.Subscribe(OnCharacterChoosed);
    }

    private void OnDisable()
    {
        characterChoosedChannel.Unsubscribe(OnCharacterChoosed);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (!characterChoosed || PauseManager.Instance.IsPaused)
            return;

        Debug.Log("Door triggered");
        LobbyDoorTriggeredChannel.Raise();
        windowsController.Open(LevelChooseWindow);
    }

    private void OnCharacterChoosed(CharacterData data)
    {
        characterChoosed = true;
    }
}
