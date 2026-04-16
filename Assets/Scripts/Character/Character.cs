using System;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] private CharacterMovement movement;
    [SerializeField] private CharacterSprite sprite;

    private CharacterModel model;

    public void Setup(CharacterData data)
    {
        model = new CharacterModel(data);

        movement.Setup(model);
        sprite.Setup(data.Sprite);
    }
}
