using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    [SerializeField] private GameObject invIcon1, invIcon2, invIcon3, invIcon4, invIcon5, invIcon6, invIcon7, invIcon8, invIcon9, invIcon10;
    [SerializeField] private Text invText1, invText2, invText3, invText4, invText5, invText6, invText7,invText8, invText9, invText10;
    public int invBattery, invCopperW, invCircuitB, invGlass , invMicroP , invPlasticS , invScrews , invSpool, invNum9, invNum10;
    // Start is called before the first frame update
    void Start()
    {
        invBattery = 0;
        invCopperW = 0;
        invCircuitB = 0;
        invGlass = 0;
        invMicroP = 0;
        invPlasticS = 0;
        invScrews = 0;
        invSpool = 0;
        invNum9 = 0; invNum10 = 0;
        invText1.text = "Battery x " + invBattery.ToString();
        invText2.text = "Copper wire x " + invCopperW.ToString();
        invText3.text = "Circuit board x " + invCircuitB.ToString();
        invText4.text = "Glass x " + invGlass.ToString();
        invText5.text = "Micro-plastic x " + invMicroP.ToString();
        invText6.text = "Plastic sheet x " + invPlasticS.ToString();
        invText7.text = "Screws x " + invScrews.ToString();
        invText8.text = "Spool x " + invSpool.ToString();
        invText9.text = "Plastic x " + invNum9.ToString();
        invText10.text = "Plastic x " + invNum10.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
