using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalScore : MonoBehaviour
{

    Text finalscore;
    float newhighscore;
    public static float numberofcoins=0;
    float cointcount;
    // Start is called before the first frame update
    void Start()
    {

        finalscore = GetComponent<Text>();
        finalscore.text = "" + Mathf.Ceil(LiveScore.score) + "";

    }

    // Update is called once per frame
    void Update()
    {
        if (LiveScore.score > HighScore.jmprhighscore)
        {
            newhighscore = LiveScore.score;
            HighScore.jmprhighscore = Mathf.Ceil(newhighscore);
            PlayerPrefs.SetFloat("BestScore", Mathf.Ceil(newhighscore));
        }

    }
}
