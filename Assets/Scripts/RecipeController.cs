using System;
using System.Collections.Generic;
using UnityEngine;

public class RecipeController : MonoBehaviour
{
    [SerializeField]
    private List<RecipeConfig> _recipeConfigs;

    [SerializeField]
    private Transform _verticalViewObject;

    [SerializeField]
    private GameObject _recipeOptionPrefab;

    public event EventHandler<RecipeConfig> RequestItemCraft;

    private void Start()
    {
#if UNITY_EDITOR
        RequestItemCraft += DebugCraftRequest;
#endif
        foreach (var config in _recipeConfigs)
        {
            var go = Instantiate(_recipeOptionPrefab, _verticalViewObject);
            var option = go.GetComponent<RecipeOption>();
            option.Init(config);
            option.CraftRequested += OnCraftRequested;
        }
    }

    private void OnCraftRequested(object sender, RecipeConfig e) => RequestItemCraft?.Invoke(this, e);

#if UNITY_EDITOR
    private void DebugCraftRequest(object sender, RecipeConfig recipeConfig) =>
        Debug.Log("Request to craft: " + recipeConfig.Output.ItemName);

#endif
}