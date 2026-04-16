using UnityEngine;

public class CharacterSprite : MonoBehaviour
{
    [SerializeField] private SpriteRenderer spriteRenderer;

    public void Setup(Sprite sprite)
    {
        spriteRenderer.sprite = sprite;
    }
}
