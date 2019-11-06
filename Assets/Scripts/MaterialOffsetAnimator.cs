using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialOffsetAnimator : MonoBehaviour
{
    [SerializeField] 
    private Material _target;

    [SerializeField] 
    private float _rotationSpeed = 1; 

    [SerializeField] 
    private OffsetAxis _targetOffsetAxis;

    private void Update()
    {
        var currentOffset = _target.GetTextureOffset("_MainTex");
        switch (_targetOffsetAxis)
        {
            case OffsetAxis.X:
                _target.SetTextureOffset("_MainTex", new Vector2(currentOffset.x + (Time.deltaTime * _rotationSpeed), currentOffset.y));
                break;
            case OffsetAxis.Y:
                _target.SetTextureOffset("_MainTex", new Vector2(currentOffset.x, currentOffset.y + (Time.deltaTime * _rotationSpeed)));
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }
}