using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoreCoins : MonoBehaviour
{
    Text coinss;
    float coiny;
    // Start is called before the first frame update
    void Start()
    {
        coiny = PlayerPrefs.GetFloat("NumberofCoins", coiny);
        coinss = GetComponent<Text>();
        coiny = coiny + CoinControl.plusthisround;
    }

    // Update is called once per frame
    void Update()
    {
        coinss.text = "" + coiny + "";
        PlayerPrefs.SetFloat("NumberofCoins", coiny);
    }
}
