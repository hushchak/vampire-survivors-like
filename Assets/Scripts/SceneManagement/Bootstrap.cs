using UnityEngine;

public class Bootstrap : MonoBehaviour
{
    private async void Start()
    {
        // TODO: Setup logic

        await SceneLoader.LoadScene(SceneList.Slots.Main, SceneList.Names.MainMenu, SceneArgs.Empty, true);
    }
}
