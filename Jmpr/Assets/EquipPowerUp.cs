using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class EquipPowerUp : MonoBehaviour
{
    string currentpower;
    public GameObject DBEquip;
    public GameObject InvEquip;
    public GameObject XLEquip;
    public Color defaultcolor;
    public Color selectedcolor;
    // Start is called before the first frame update
    void Start()
    {   
    }
    // Update is called once per frame
    void Update()
    {
    }

    public void EquipDoubleCoins()
    {
        currentpower = "DoubleCoins";
        PlayerPrefs.SetString("EquipedPowerUp", currentpower);
        DBEquip.GetComponent<Image>().color = selectedcolor;
        InvEquip.GetComponent<Image>().color = defaultcolor;
        XLEquip.GetComponent<Image>().color = defaultcolor;
    }

    public void EquipInvincibility()
    {
        currentpower = "Invincibility";
        PlayerPrefs.SetString("EquipedPowerUp", currentpower);
        InvEquip.GetComponent<Image>().color = selectedcolor;
        DBEquip.GetComponent<Image>().color = defaultcolor;
        XLEquip.GetComponent<Image>().color = defaultcolor;
    }

    public void EquipExtraLives()
    {
        currentpower = "ExtraLives";
        PlayerPrefs.SetString("EquipedPowerUp", currentpower);
      
        XLEquip.GetComponent<Image>().color = selectedcolor;
        InvEquip.GetComponent<Image>().color = defaultcolor;
        DBEquip.GetComponent<Image>().color = defaultcolor;
    }
}
