using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ResourceController : MonoBehaviour
{
    [SerializeField] private GameObject inventoryScript;
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

    private void ProcessStatModifiersAndByproducts(ResourceTypeConfig config)
    {
        
        Debug.Log($"Player would receive {string.Join(", ", config.ResourceByproducts.Any() ? config.ResourceByproducts.Select(x => x.ResourceName) : new List<string>(){"None"})} resources and {string.Join(", ", config.ResourceTraits.Any() ? config.ResourceTraits.Select(x => x.StatusModifier.ToString() + " - " + x.ModificationAmount) : new List<string>() {"None"})} traits.");
        
        if (config.ResourceByproducts.FirstOrDefault(x => x.ResourceName == Inventory.invCopperWName))
        {
            inventoryScript.GetComponent<Inventory>().UpdateCopperW(1);

        }
        else if (config.ResourceByproducts.FirstOrDefault(x => x.ResourceName == Inventory.invBatteryName))
        {
            inventoryScript.GetComponent<Inventory>().UpdateBattery(1);
        }       
        else if (config.ResourceByproducts.FirstOrDefault(x => x.ResourceName == Inventory.invSpoolName))
        {
            inventoryScript.GetComponent<Inventory>().UpdateSpool(1);
        }
        else if (config.ResourceByproducts.FirstOrDefault(x => x.ResourceName == Inventory.invScrewsName))
        {
            inventoryScript.GetComponent<Inventory>().UpdateScrews(1);;
        }
        else if (config.ResourceByproducts.FirstOrDefault(x => x.ResourceName == Inventory.invMicroPName))
        {
            inventoryScript.GetComponent<Inventory>().UpdateMicroPlastic(1);
        }
        else if (config.ResourceByproducts.FirstOrDefault(x => x.ResourceName == Inventory.invPlasticSName))
        {
            inventoryScript.GetComponent<Inventory>().UpdatePlasticS(1);
        }
        else if (config.ResourceByproducts.FirstOrDefault(x => x.ResourceName == Inventory.invCircuitBName))
        {
            inventoryScript.GetComponent<Inventory>().UpdateCircuitB(1);
        }
    } 
    private void Update()
    {
        if (_currentResource != null || _recycleQueue.Count == 0) return;

        _currentResource = _recycleQueue.Peek();
        
        if (_currentResource == null) return;
        
        _currentResource.BeginProgress();
    }
}
