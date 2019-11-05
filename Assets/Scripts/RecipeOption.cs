using System;
using TMPro;
using UnityEngine;

public class RecipeOption : MonoBehaviour
{
    [SerializeField]
    private TMP_Text _name;

    [SerializeField]
    private GameObject _icon;

    [SerializeField]
    private GameObject _recipeIconOne;
    
    [SerializeField]
    private GameObject _recipeIconTwo;
    
    [SerializeField]
    private TMP_Text _resourceNameOne;   
    
    [SerializeField]
    private TMP_Text _resourceNameTwo;

    private RecipeConfig _recipe;

    public event EventHandler<RecipeConfig> CraftRequested; 

    public void Init(RecipeConfig recipe)
    {
        _recipe = recipe;
        _name.text = recipe.Output.ItemName;
        _resourceNameOne.text = $"{recipe.InputOne.ItemName} x {recipe.InputOneAmount}";
        _resourceNameTwo.text = $"{recipe.InputTwo.ItemName} x {recipe.InputTwoAmount}";
    }

    public void AttemptCraft() => CraftRequested?.Invoke(this, _recipe);
}