using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.EventSystems;

public class InventoryOpen : MonoBehaviour
{
    public GameObject panel;

    private void OpenPanel()
    {
        Animator animator = panel.GetComponent<Animator>();
        if (panel != null) {
            bool isOpen = animator.GetBool("open");
            animator.SetBool("open", !isOpen);
        }
        
        
}

    void GetPooled()
    {
        Debug.Log("Mouse is over GameObject.");
        OpenPanel();
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
