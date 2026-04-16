using UnityEngine;

[CreateAssetMenu(menuName = "CharacterData", fileName = "CharacterData")]
public class CharacterData : ScriptableObject
{
    [field: SerializeField] public float MovementSpeed { get; private set; }
}
