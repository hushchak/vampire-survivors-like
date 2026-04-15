using UnityEngine;

public abstract class Window : MonoBehaviour
{
    [SerializeField] protected WindowsController controller;

    public virtual void Open()
    {
    }

    public virtual void Close()
    {
    }
}
