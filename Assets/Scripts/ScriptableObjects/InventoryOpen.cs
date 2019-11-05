using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.EventSystems;

public class InventoryOpen : MonoBehaviour
{
    public GameObject invpanel;
    public GameObject showpanel, hidepanel;
    public Button theButton;

    public void OpenPanel()
    {
        if (invpanel.activeSelf)
        {
            invpanel.SetActive(false);
            showpanel.SetActive(true);
            hidepanel.SetActive(false);
            
        }
        else
        {
            invpanel.SetActive(true);
            hidepanel.SetActive(true);
            showpanel.SetActive(false);
        }



    }
    

// Start is called before the first frame update
void Start()
{
}

// Update is called once per frame
void Update()
{
    
}

/*
 *  public class MyClass: MonoBehaviour, IPointerEnterHandler{
     
     public void OnPointerEnter(PointerEventData eventData)
     {
         //do stuff
     }
 */
}
