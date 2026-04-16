using System;
using UnityEngine;

public class PauseManager : Singleton<PauseManager>
{
    public bool IsPaused { get; private set; }

    public void SetPause(bool pause)
    {
        IsPaused = pause;

        if (IsPaused)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
    }
}
