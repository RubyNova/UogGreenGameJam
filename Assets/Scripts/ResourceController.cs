using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ResourceController : MonoBehaviour
{
    [SerializeField]
    private List<ResourceTypeConfig> _resourceConfigs;

    [SerializeField]
    private Transform _verticalViewObject;

    [SerializeField]
    private GameObject _resourceOptionPrefab;

    private readonly Queue<ResourceOption> _recycleQueue = new Queue<ResourceOption>();
    private ResourceOption _currentResource;

    private void Start()
    {
        foreach (var config in _resourceConfigs)
        {
            var go = Instantiate(_resourceOptionPrefab, _verticalViewObject);
            var option = go.GetComponent<ResourceOption>();
            option.Init(config);
            option.ResourceRequestsRecycling += OnRecycleRequest;
        }
    }

    private void OnRecycleRequest(object sender, ResourceOption e)
    {
        if (_recycleQueue.Contains(e))
        {
            Debug.LogError($"Somehow, a duplicate recycle request was made! Config: {e.Config.ResourceName}");
            return;
        }
        
        _recycleQueue.Enqueue(e);
        e.ResourceFinishedRecycling += OnResourceFinishedRecycling;
    }

    private void OnResourceFinishedRecycling(object sender, ResourceOption e)
    {
        ProcessStatModifiersAndByproducts(e.Config);
        _recycleQueue.Dequeue();
        e.ResourceFinishedRecycling -= OnResourceFinishedRecycling;
        _currentResource = null;
    }

    private void ProcessStatModifiersAndByproducts(ResourceTypeConfig config) => Debug.Log($"Player would receive {string.Join(", ", config.ResourceByproducts.Any() ? config.ResourceByproducts.Select(x => x.ResourceName) : new List<string>(){"None"})} resources and {string.Join(", ", config.ResourceTraits.Any() ? config.ResourceTraits.Select(x => x.StatusModifier.ToString() + " - " + x.ModificationAmount) : new List<string>() {"None"})} traits.");

    private void Update()
    {
        if (_currentResource != null) return;

        _currentResource = _recycleQueue.Peek();
        
        if (_currentResource == null) return;
        
        _currentResource.BeginProgress();
    }
}
