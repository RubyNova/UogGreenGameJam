using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transform_Object : MonoBehaviour
{
    public GameObject Input;
    public Transform Output;
    public Transform Stop;
    public GameObject Product;
    public float step;
    public float Distance;

    void Update()
    {
        Distance = Vector3.Distance(transform.position, Output.position);
        step = 1f;

        Input.transform.position = Vector3.MoveTowards(Input.transform.position, Output.position, step);

        if (Distance >= 0.1f && Input.activeSelf == true)
        {
            Instantiate(Product);
            Input.SetActive(false);
        }
    }
}
