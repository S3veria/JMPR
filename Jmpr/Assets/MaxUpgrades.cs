using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaxUpgrades : MonoBehaviour
{
    public GameObject MaxDCEquip;
    public GameObject MaxInvEquip;
    public GameObject MaxXLEquip;
    public GameObject MaxDCPlus;
    public GameObject MaxInvPlus;
    public GameObject MaxXLPlus;
    bool var1 = true;
    // Start is called before the first frame update
    void Start()
    {
        MaxDCEquip.SetActive(false);
        MaxDCPlus.SetActive(false);
        MaxInvEquip.SetActive(false);
        MaxInvPlus.SetActive(false);
        MaxXLEquip.SetActive(false);
        MaxXLPlus.SetActive(false);
        PlayerPrefs.SetInt("DCnormalbuttons", 0);
        PlayerPrefs.SetInt("Invnormalbuttons", 0);
        PlayerPrefs.SetInt("XLnormalbuttons", 0);

    }

    // Update is called once per frame
    void Update()
    {
        if ((UpgradePower.upgradesDC <= 5)&&var1)
        {
            MaxDCEquip.SetActive(false);
            MaxDCPlus.SetActive(false);
            Upgrades.DCunlocked = false;
            Upgrades.destroydcc = true;
            var1 = false;
        }
        else
        {
            MaxDCEquip.SetActive(true);
            MaxDCPlus.SetActive(true);
        }
        if (UpgradePower.upgradesInv <= 5)
        {
            MaxInvEquip.SetActive(false);
            MaxInvPlus.SetActive(false);
            Upgrades.INV = 1;
            Upgrades.INVunlocked = 0;
        }
        else
        {
            MaxInvEquip.SetActive(true);
            MaxInvPlus.SetActive(true);
        }
        if (UpgradePower.upgradesXL <= 5)
        {
            MaxXLEquip.SetActive(false);
            MaxXLPlus.SetActive(false);
            Upgrades.XL = 1;
            Upgrades.XLunlocked = 0;
        }
        else
        {
            MaxXLEquip.SetActive(true);
            MaxXLPlus.SetActive(true);
        }
    }

}
