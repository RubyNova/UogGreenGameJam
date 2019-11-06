using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ResourceOption : MonoBehaviour
{
    public event EventHandler<ResourceOption> ResourceRequestsRecycling;
    public event EventHandler<ResourceOption> ResourceFinishedRecycling;
    
    [SerializeField]
    private TMP_Text _name;
    
    [SerializeField]
    private TMP_Text _resourceByproducts;

    [SerializeField]
    private Image _progressBar;

    [SerializeField]
    private GameObject _recycleButton;

    [SerializeField] 
    private Transform _iconPosition;
    
    public ResourceTypeConfig Config { get; private set; }

    public void Init(ResourceTypeConfig config)
    {
        var thisRect = (RectTransform)_iconPosition;
        Config = config;
        _name.text = config.ResourceName;
        _resourceByproducts.text = "Byproducts: " + string.Join(", ", config.ResourceByproducts.Any() ? config.ResourceByproducts.Select(x => x.ResourceName) : new List<string>() {"None"});
        var rect = Instantiate(config.ResourceModelIcon, _iconPosition).GetComponentInChildren<RectTransform>();
        rect.parent = transform;
        rect.anchoredPosition = thisRect.anchoredPosition;
        rect.anchorMin = thisRect.anchorMin;
        rect.anchorMax = thisRect.anchorMax;
        rect.offsetMax = thisRect.offsetMax;
        rect.offsetMin = thisRect.offsetMin;
    }

    public void RecycleResource()
    {
        _recycleButton.SetActive(false);
        ResourceRequestsRecycling?.Invoke(this, this);
    }

    public void BeginProgress() => StartCoroutine(CycleProgressBar());

    private IEnumerator CycleProgressBar()
    {
        _progressBar.fillAmount = 0;

        float duration = 0f;

        while (duration < Config.ConsumptionDuration)
        {
            _progressBar.fillAmount = Math.Abs(duration) < 0 ? 0 : duration / Config.ConsumptionDuration;
            duration += Time.deltaTime;
            yield return null;
        }

        ResourceFinishedRecycling?.Invoke(this, this);
        _progressBar.fillAmount = 0;
        duration = 0;
        
        while (duration < Config.CooldownPeriod)
        {
            _progressBar.fillAmount = Math.Abs(duration) < 0 ? 0 : duration / Config.CooldownPeriod;
            duration += Time.deltaTime;
            yield return null;
        }
        
        _recycleButton.SetActive(true);
    }
}