using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    public static float jmprhighscore=0;
    Text High;

    // Start is called before the first frame update
    void Start()
    {
        jmprhighscore = PlayerPrefs.GetFloat("BestScore", jmprhighscore);
        High = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        High.text = "" + jmprhighscore + "";
    }
}
