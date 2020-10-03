using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LiveScore : MonoBehaviour
{
    public static float score = 0;
    public static float realscore = 0;
    Text currentscore;
    // Start is called before the first frame update
    void Start()
    {
        currentscore = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        currentscore.text = "" + Mathf.Ceil(score) + "";
    }
}
