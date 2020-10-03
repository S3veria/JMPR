using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Upgrades : MonoBehaviour
{

    public  GameObject DCUpgrade;
    public  GameObject InvUpgrade;
    public  GameObject XLUpgrade;
    public  GameObject DCEquip;
    public  GameObject InvEquip;
    public  GameObject XLEquip;
    public  GameObject DCPlus;
    public  GameObject InvPlus;
    public  GameObject XLPlus;
    public static int DC;
    public static int INV;
    public static int XL;
    public static bool DCunlocked;
    public static int INVunlocked;
    public static int XLunlocked;
    public static bool destroydcc = false;


    // Start is called before the first frame update
    void Start()
    {



    }

    // Update is called once per frame
    void Update()
    {
        DC = PlayerPrefs.GetInt("DCnormalbuttons", DC);
        INV = PlayerPrefs.GetInt("INVnormalbuttons", INV);
        XL = PlayerPrefs.GetInt("XLnormalbuttons", XL);

        INVunlocked = PlayerPrefs.GetInt("INVunlocked", INVunlocked);
        XLunlocked = PlayerPrefs.GetInt("XLunlocked", XLunlocked);
        if (DCunlocked)
        {
            DCUpgrade.SetActive(true);
            DCPlus.SetActive(true);
            DCEquip.SetActive(true);
        }
        if (INVunlocked == 1)
        {
            InvUpgrade.SetActive(false);
            InvPlus.SetActive(false);
            InvEquip.SetActive(false);
        }
        if (XLunlocked == 1)
        {
            XLUpgrade.SetActive(false);
            XLPlus.SetActive(false);
            XLEquip.SetActive(false);
        }


        /*
        if (destroydcc == true)
        {
            destroydcc = false;
            destroydc();
        }
        */
    }
    /*
    public void destroydc()
    {
        Destroy(DCUpgrade);
        Destroy(DCPlus);
        Destroy(DCEquip);
    }
    */

}
