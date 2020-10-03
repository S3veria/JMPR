using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class numberofcoinss : MonoBehaviour
{

    public static float numbcoins=0;
    Text coinss;

    // Start is called before the first frame update
    void Start()
    {
        numbcoins = PlayerPrefs.GetFloat("NumberofCoins", numbcoins);
        coinss = GetComponent<Text>();
        numbcoins = numbcoins + CoinControl.plusthisround;
        CoinControl.plusthisround = 0;
    }

    // Update is called once per frame
    void Update()
    {
        coinss.text = "" + numbcoins + "";
        PlayerPrefs.SetFloat("NumberofCoins", numbcoins);
    }
}
