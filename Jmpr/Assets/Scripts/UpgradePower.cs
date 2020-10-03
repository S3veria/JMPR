using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradePower : MonoBehaviour
{

    public static float upgradesDC;
    public static float upgradesXL;
    public static float upgradesInv;
    float coins;
    
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetFloat("NumberofCoins", 10000);
        PlayerPrefs.SetFloat("DCUpgrades", 0);
        PlayerPrefs.SetFloat("InvUpgrades", 0);
        PlayerPrefs.SetFloat("XLUpgrades", 0);
    }

    // Update is called once per frame
    void Update()
    {
        upgradesInv = PlayerPrefs.GetFloat("InvUpgrades", upgradesInv);
        upgradesDC = PlayerPrefs.GetFloat("DCUpgrades", upgradesDC);
        upgradesXL = PlayerPrefs.GetFloat("XLUpgrades", upgradesXL);
    }


    public void DCUpgrade()
    {

        coins = PlayerPrefs.GetFloat("NumberofCoins", coins);
        upgradesDC = PlayerPrefs.GetFloat("DCUpgrades", upgradesDC);
        if (upgradesDC <= 5)
        {
            upgradesDC = upgradesDC + 1;
            coins = coins - 1000;
            PlayerPrefs.SetFloat("NumberofCoins", coins);
            PlayerPrefs.SetFloat("DCUpgrades", upgradesDC);
            Debug.Log(upgradesDC);
        }

        else
        {

        }


    }

    public void InvUpgrade()
    {
        coins = PlayerPrefs.GetFloat("NumberofCoins", coins);
        upgradesInv = PlayerPrefs.GetFloat("InvUpgrades", upgradesInv);
        if (upgradesInv <= 5)
        {
            upgradesInv = upgradesInv + 1;
            coins = coins - 1000;
            PlayerPrefs.SetFloat("NumberofCoins", coins);
            PlayerPrefs.SetFloat("InvUpgrades", upgradesInv);
            Debug.Log(upgradesInv);
        }

        else
        {

        }

    }

    public void XLUpgrade()
    {
        coins = PlayerPrefs.GetFloat("NumberofCoins", coins);
        upgradesXL = PlayerPrefs.GetFloat("XLUpgrades", upgradesXL);
        if (upgradesDC <= 5)
        {
            upgradesXL = upgradesXL + 1;
            coins = coins - 1000;
            PlayerPrefs.SetFloat("NumberofCoins", coins);
            PlayerPrefs.SetFloat("XLUpgrades", upgradesDC);
            Debug.Log(upgradesXL);
        }

        else
        {

        }

    }

}
