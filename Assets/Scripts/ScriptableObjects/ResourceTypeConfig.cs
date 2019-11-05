using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "NewResourceConfig", menuName = "Game Configurations/New Resource Config", order = 0)]
public class ResourceTypeConfig : ScriptableObject
{
    [SerializeField]
    private string _name;

    [SerializeField]
    private float _consumptionDuration;

    [SerializeField]
    private float _cooldownPeriod;

    [SerializeField]
    private List<ResourceTypeConfig> _resourceByproducts;

    [SerializeField]
    private GameObject _resourceModelIcon;

    [SerializeField]
    private List<ResourceTraitConfig> _resourceTraits;

    public string Name => _name;

    public float ConsumptionDuration => _consumptionDuration;

    public float CooldownPeriod => _cooldownPeriod;

    public List<ResourceTypeConfig> ResourceByproducts => _resourceByproducts;

    public GameObject ResourceModelIcon => _resourceModelIcon;

    public List<ResourceTraitConfig> ResourceTraits => _resourceTraits;
}