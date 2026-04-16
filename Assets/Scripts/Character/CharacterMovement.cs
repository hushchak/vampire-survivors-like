using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    private CharacterModel model;

    public void Setup(CharacterModel model)
    {
        this.model = model;
    }

    private void FixedUpdate()
    {
        if (PauseManager.Instance.IsPaused)
            return;

        Vector2 movementOffset = InputReader.InputVector.normalized * model.GetMovementSpeed() * Time.fixedDeltaTime;
        transform.position = (Vector2)transform.position + movementOffset;
    }
}
