using UnityEngine;

[CreateAssetMenu(fileName = "NewResourceTraitConfig", menuName = "Game Configurations/New Resource Trait Config", order = 1)]
public class ResourceTraitConfig : ScriptableObject
{
    [SerializeField]
    private StatusModifier _statusModifier;

    [SerializeField]
    private float _modificationAmount;

    [SerializeField]
    private float _percentageChance = 100;

    [SerializeField]
    private InventoryItemConfig _rareItemConfig;

    public StatusModifier StatusModifier => _statusModifier;

    public float ModificationAmount => _modificationAmount;

    public float PercentageChance => _percentageChance;

    public InventoryItemConfig RareItemConfig => _rareItemConfig;
}