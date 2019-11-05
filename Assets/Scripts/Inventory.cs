using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    [SerializeField] private GameObject invIcon1, invIcon2, invIcon3, invIcon4, invIcon5, invIcon6, invIcon7, invIcon8, invIcon9, invIcon10;
    [SerializeField] private Text invText1, invText2, invText3, invText4, invText5, invText6, invText7,invText8, invText9, invText10;

    // Start is called before the first frame update
    void Start()
    {
        int invNum1 = 0, invNum2 = 0, invNum3 = 0, invNum4 = 0, invNum5 = 0, invNum6 = 0, invNum7 = 0, invNum8 = 0, invNum9 = 0, invNum10 = 0;
        invText1.text = "Battery x " + invNum1.ToString();
        invText2.text = "Copper wire x " + invNum2.ToString();
        invText3.text = "Circuit board x " + invNum3.ToString();
        invText4.text = "Glass x " + invNum4.ToString();
        invText5.text = "Micro-plastic x " + invNum5.ToString();
        invText6.text = "Plastic sheet x " + invNum6.ToString();
        invText7.text = "Screws x " + invNum7.ToString();
        invText8.text = "Spool x " + invNum8.ToString();
        invText9.text = "Plastic x " + invNum9.ToString();
        invText10.text = "Plastic x " + invNum10.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
