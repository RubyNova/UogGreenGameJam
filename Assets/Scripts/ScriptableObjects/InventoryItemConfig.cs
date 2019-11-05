using UnityEngine;

[CreateAssetMenu(fileName = "NewItemConfig", menuName = "Game Configurations/New Item Config", order = 2)]
public class InventoryItemConfig : ScriptableObject
{
    [SerializeField]
    private string _name;

    [SerializeField]
    private GameObject _icon;

    public string Name => _name;

    public GameObject Icon => _icon;
}