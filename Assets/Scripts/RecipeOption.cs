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
        Instantiate(recipe.Output.Icon, _icon.transform.position, _icon.transform.rotation);
        Instantiate(recipe.Output.Icon, _recipeIconOne.transform);
        Instantiate(recipe.Output.Icon, _recipeIconTwo.transform);
    }

    public void AttemptCraft() => CraftRequested?.Invoke(this, _recipe);
}