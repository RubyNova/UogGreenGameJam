using UnityEngine;

[CreateAssetMenu(fileName = "NewResourceTraitConfig", menuName = "Game Configurations/New Resource Trait Config", order = 1)]
public class ResourceTraitConfig : ScriptableObject
{
    [SerializeField]
    private StatusModifier _statusModifier;

    [SerializeField]
    private float _modificationAmount;

    public StatusModifier StatusModifier => _statusModifier;

    public float ModificationAmount => _modificationAmount;
}