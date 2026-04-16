using UnityEngine;

public abstract class Window : MonoBehaviour
{
    [SerializeField] protected WindowsController controller;

    protected virtual void Awake()
    {
        gameObject.SetActive(false);
    }

    public virtual void Open()
    {
    }

    public virtual void Close()
    {
    }
}
