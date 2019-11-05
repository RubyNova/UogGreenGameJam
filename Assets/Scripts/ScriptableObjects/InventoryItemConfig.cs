using UnityEngine;

[CreateAssetMenu(fileName = "NewItemConfig", menuName = "Game Configurations/New Item Config", order = 2)]
public class InventoryItemConfig : ScriptableObject
{
    [SerializeField]
    private string _itemName;

    [SerializeField]
    private GameObject _icon;

    public string ItemName => _itemName;

    public GameObject Icon => _icon;
}