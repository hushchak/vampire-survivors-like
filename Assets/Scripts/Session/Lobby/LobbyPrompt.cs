using System.Collections;
using UnityEngine;

public class LobbyPrompt : MonoBehaviour
{
    [SerializeField] private CanvasGroup promptGroup;
    [SerializeField] private EventChannelCharacterData characterChoosedChannel;
    [SerializeField] private float fadeOutTime = 0.5f;
    private bool fadedOut = false;

    private void Awake()
    {
        characterChoosedChannel.Subscribe(StartFadeOut);
    }

    private void OnDestroy()
    {
        characterChoosedChannel.Unsubscribe(StartFadeOut);
    }

    private void StartFadeOut(CharacterData _)
    {
        if (fadedOut)
            return;

        StartCoroutine(FadeOut(fadeOutTime));
        fadedOut = true;
    }

    private IEnumerator FadeOut(float fadeOutTime)
    {
        float elapsedTime = 0f;
        while (elapsedTime < fadeOutTime)
        {
            promptGroup.alpha = Mathf.Abs(Mathf.Clamp01(elapsedTime/fadeOutTime) - 1);
            elapsedTime += Time.deltaTime;
            yield return null;
        }
        promptGroup.alpha = 0f;
    }
}
