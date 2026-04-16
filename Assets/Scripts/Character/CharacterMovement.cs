using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    private CharacterData defaultData;

    public void Setup(CharacterData data)
    {
        defaultData = data;
    }

    private void FixedUpdate()
    {
        Vector2 movementOffset = InputReader.InputVector.normalized * defaultData.MovementSpeed * Time.fixedDeltaTime;
        transform.position = (Vector2)transform.position + movementOffset;
    }
}
