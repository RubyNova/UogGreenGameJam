using UnityEngine;

[CreateAssetMenu(fileName = "NewRecipeConfig", menuName = "Game Configurations/New Recipe Config", order = 3)]
public class RecipeConfig : ScriptableObject
{
    [SerializeField]
    private InventoryItemConfig _output;
    
    [SerializeField]
    private float _outputAmount;
    
    [SerializeField]
    private InventoryItemConfig _inputOne;

    [SerializeField]
    private float _inputOneAmount;

    [SerializeField]
    private InventoryItemConfig _inputTwo;
    
    [SerializeField]
    private float _inputTwoAmount;

    public InventoryItemConfig Output => _output;

    public InventoryItemConfig InputOne => _inputOne;

    public InventoryItemConfig InputTwo => _inputTwo;

    public float InputOneAmount => _inputOneAmount;

    public float InputTwoAmount => _inputTwoAmount;

    public float OutputAmount => _outputAmount;
}