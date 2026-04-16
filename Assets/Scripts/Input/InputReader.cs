using System;
using UnityEngine;
using UnityEngine.InputSystem;

public static class InputReader
{
    private static InputSystem_Actions actions;

    public static event Action OnBackPerformed;
    public static Vector2 MousePosition => actions.Player.MousePosition.ReadValue<Vector2>();
    public static Vector2 InputVector => actions.Player.Move.ReadValue<Vector2>();

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void Initialize()
    {
        actions = new InputSystem_Actions();
        actions.Enable();

        actions.Player.Back.performed += BackPerfomed;
    }

    private static void BackPerfomed(InputAction.CallbackContext context)
    {
        OnBackPerformed?.Invoke();
    }
}
