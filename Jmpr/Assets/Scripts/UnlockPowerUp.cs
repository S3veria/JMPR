using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UnlockPowerUp : MonoBehaviour
{

    public GameObject DoubleCoinsButton;
    public GameObject InvincibilityButton;
    public GameObject ExtraLifeButton;
    float currentcoins;
    float doublecoinsnumb=1;
    float invincibilitynumb = 1;
    float extralivesnumb = 1;
    float initialupgrades=0;
    // Start is called before the first frame update
    void Start()
    {
        currentcoins = 10000;
        PlayerPrefs.SetFloat("NumberofCoins", currentcoins);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UnlockDoubleCoins()
    {
        currentcoins=PlayerPrefs.GetFloat("NumberofCoins", currentcoins);
        Destroy(DoubleCoinsButton);
        currentcoins = currentcoins - 500;
        PlayerPrefs.SetFloat("NumberofCoins", currentcoins);
        Upgrades.DCunlocked = true;
        PlayerPrefs.SetFloat("AvailableDoubleCoins", doublecoinsnumb);
        PlayerPrefs.SetFloat("DCUpgrades", initialupgrades);
        PlayerPrefs.SetString("EquipedPowerUp", "DoubleCoins");
    }

    public void UnlockInvincibility()
    {
        currentcoins = PlayerPrefs.GetFloat("NumberofCoins", currentcoins);
        InvincibilityButton.SetActive(false);
        currentcoins = currentcoins - 1250;
        PlayerPrefs.SetFloat("NumberofCoins", currentcoins);
        PlayerPrefs.SetInt("INVunlocked", 1);
        PlayerPrefs.SetFloat("AvailableInvincibility", invincibilitynumb);
        PlayerPrefs.SetFloat("InvUpgrades", initialupgrades);
        PlayerPrefs.SetString("EquipedPowerUp", "Invincibility");

    }



    public void UnlockExtralives()
    {
        currentcoins = PlayerPrefs.GetFloat("NumberofCoins", currentcoins);
        ExtraLifeButton.SetActive(false);
        currentcoins = currentcoins - 2500;
        PlayerPrefs.SetFloat("NumberofCoins", currentcoins);
        PlayerPrefs.SetInt("XLunlocked", 1);
        PlayerPrefs.SetFloat("AvailableExtralives", extralivesnumb);
        PlayerPrefs.SetFloat("XLUpgrades", initialupgrades);
        PlayerPrefs.SetString("EquipedPowerUp", "ExtraLives");
    }



}
