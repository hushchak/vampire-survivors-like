public class CharacterModel
{
    private CharacterData defaultData;

    public CharacterModel(CharacterData data)
    {
        defaultData = data;
    }

    public float GetMaxHealthPoints() => defaultData.MaxHealthPoints;
    public float GetRegeneration() => defaultData.Regeneration;
    public int GetDefence() => defaultData.Defence;
    public float GetMovementSpeed() => defaultData.MovementSpeed;
    public float GetAttackSpeed() => defaultData.AttackSpeed;
    public float GetCritChance() => defaultData.CritChance;
    public float GetPickingRadius() => defaultData.PickingRadius;
}
