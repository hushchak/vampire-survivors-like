using UnityEngine;

public class WindowsController : MonoBehaviour
{
    private Window currentWindow = null;

    public void Open(Window window)
    {
        if (currentWindow == window) return;

        currentWindow?.Close();

        window.Open();
        currentWindow = window;
    }

    public void Close()
    {
        currentWindow.Close();
        currentWindow = null;
    }
}
