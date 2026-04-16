using UnityEngine;

public class LevelChooseWindow : Window
{
    [SerializeField] private LevelData Level1Data;
    [SerializeField] private LevelData Level2Data;
    [SerializeField] private LevelData Level3Data;

    private LevelData currentChosenLevel;

    public override void Open()
    {
        PauseManager.Instance.SetPause(true);

        DisplayUnlockedLevels();
        gameObject.SetActive(true);

        InputReader.OnBackPerformed += controller.Close;
    }

    public override void Close()
    {
        gameObject.SetActive(false);
        PauseManager.Instance.SetPause(false);

        InputReader.OnBackPerformed -= controller.Close;
    }

    private void DisplayUnlockedLevels()
    {
        GameData data = SaveManager.GetGameData();

        currentChosenLevel = Level1Data;
        //TODO: Adds unlocked levels to menu
    }

    public void LoadChosenLevel()
    {
        SessionManager.Instance.LoadRunScene(currentChosenLevel);
    }
}
