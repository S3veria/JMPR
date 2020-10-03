using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyPowerUp : MonoBehaviour
{

    float doublecoinsnum;
    float invincibilitynum;
    float extralifenum;
    float coinsrn;
    // Start is called before the first frame update
    void Start()
    {
        doublecoinsnum = PlayerPrefs.GetFloat("AvailableDoubleCoins", doublecoinsnum);
        invincibilitynum = PlayerPrefs.GetFloat("AvailableInvincibility", invincibilitynum);
        extralifenum = PlayerPrefs.GetFloat("AvailableExtralives", extralifenum);
        coinsrn= PlayerPrefs.GetFloat("NumberofCoins", coinsrn);
    }
    // Update is called once per frame
    void Update()
    { 
    }

    public void BuyDoubleCoins()
    {
        coinsrn = PlayerPrefs.GetFloat("NumberofCoins", coinsrn);
        doublecoinsnum = PlayerPrefs.GetFloat("AvailableDoubleCoins", doublecoinsnum);
        doublecoinsnum = doublecoinsnum + 1;
        PlayerPrefs.SetFloat("AvailableDoubleCoins", doublecoinsnum);
        coinsrn = coinsrn - 100;
        PlayerPrefs.SetFloat("NumberofCoins", coinsrn);
    }

    public void BuyInvincibility()
    {
        coinsrn = PlayerPrefs.GetFloat("NumberofCoins", coinsrn);
        invincibilitynum = PlayerPrefs.GetFloat("AvailableInvincibility", invincibilitynum);
        invincibilitynum = invincibilitynum + 1;
        PlayerPrefs.SetFloat("AvailableInvincibility", invincibilitynum);
        coinsrn = coinsrn - 150;
        PlayerPrefs.SetFloat("NumberofCoins", coinsrn);
    }

    public void BuyExtraLives()
    {
        extralifenum = PlayerPrefs.GetFloat("AvailableExtralives", extralifenum);
        coinsrn = PlayerPrefs.GetFloat("NumberofCoins", coinsrn);
        extralifenum = extralifenum + 1;
        PlayerPrefs.SetFloat("AvailableExtralives", extralifenum);
        coinsrn = coinsrn - 200;
        PlayerPrefs.SetFloat("NumberofCoins", coinsrn);
    }

}
