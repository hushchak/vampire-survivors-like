using UnityEngine;

[CreateAssetMenu(menuName = "CharacterData", fileName = "CharacterData")]
public class CharacterData : ScriptableObject
{
    [field: SerializeField] public Sprite Sprite { get; private set; }
    [field:Space]
    [field: SerializeField] public float MaxHealthPoints { get; private set; } = 50;
    [field: SerializeField] public float Regeneration { get; private set; } = 0.2f;
    [field: SerializeField] public int Defence { get; private set; } = 1;
    [field: SerializeField] public float MovementSpeed { get; private set; } = 4.5f;
    [field: SerializeField] public float AttackSpeed { get; private set; } = 2f;
    [field: SerializeField, Range(0f, 100f)] public float CritChance { get; private set; } = 2.5f;
    [field: SerializeField] public float PickingRadius { get; private set; } = 2.5f;
}
