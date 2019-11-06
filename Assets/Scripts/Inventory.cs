using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public GameObject inv1, inv2, inv3, inv4, inv5, inv6, inv7;
    public Text invText1, invText2, invText3, invText4, invText5, invText6, invText7;
    public int invBattery, invCopperW, invCircuitB, invGlass , invMicroP , invPlasticS , invScrews , invSpool, invNum9, invNum10;
    public int invBatteryUpdate, invCopperWUpdate, invCircuitBUpdate , invMicroPUpdate , invPlasticSUpdate , invScrewsUpdate , invSpoolUpdate, invNum9Update, invNum10Update;

     
    public static string invBatteryName = "Battery",
        invCopperWName = "Copper Wire",
        invCircuitBName = "Circuit Board",
        invMicroPName = "Micro-plastic",
        invPlasticSName = "Plastic Sheet",
        invScrewsName = "Screws",
        invSpoolName = "Spool";
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
        invBatteryUpdate = 0;
        invCopperWUpdate = 0;
        invCircuitBUpdate = 0;
        invMicroPUpdate = 0;
        invPlasticSUpdate = 0;
        invScrewsUpdate = 0;
        invSpoolUpdate = 0;
        invNum9Update = 0; invNum10Update = 0;
        invText1.text = invBatteryName + " x " + invBattery.ToString();
        invText2.text = invCopperWName+ " x " + invCopperW.ToString();
        invText3.text = invCircuitBName + " x " + invCircuitB.ToString();
        invText4.text = invMicroPName + " x " + invMicroP.ToString();
        invText5.text = invPlasticSName + " x " + invPlasticS.ToString();
        invText6.text = invScrewsName + " x " + invScrews.ToString();
        invText7.text = invSpoolName + " x " + invSpool.ToString();
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    
    

        
    
    public void UpdateBattery(int num)
    {
        invBatteryUpdate += num;
        invText1.text = invBatteryName + " x " + invBatteryUpdate.ToString();
    }
    public void UpdateCopperW(int num)
    {
        invCopperWUpdate  += num;
        invText2.text = invCopperWName + " x " + invCopperWUpdate.ToString();

    }
    public void UpdateCircuitB(int num)
    {
        invCircuitBUpdate += num;
        invText3.text = invCircuitBName + " x " + invCircuitBUpdate.ToString();
    }
    public void UpdatePlasticS(int num)
    {
        invPlasticSUpdate += num;
        invText5.text = invCircuitBName + " x " + invPlasticSUpdate.ToString();
    }
    public void UpdateMicroPlastic(int num)
    {
        invMicroPUpdate += num;
        invText4.text = invMicroPName + " x " + invMicroPUpdate.ToString();
    }
    public void UpdateScrews(int num)
    {
        invScrewsUpdate += num;
        invText6.text = invScrewsName + " x " + invScrewsUpdate.ToString();
    }
    public void UpdateSpool(int num)
    {
        invSpoolUpdate += num;
        invText7.text = invSpoolName + " x " + invSpoolUpdate.ToString();
    }
}
