using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallScroll : MonoBehaviour
{
    public Rigidbody2D wallrigid;
    public static float speedup = 4.0f;
    public static float speedup2=0.05f;
    private double speed=4;
    private Vector2 screenBounds;
    public Transform wallcoordinates;
    public float obstaclespawntime = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));

    }

    // Update is called once per frame
    void Update()
    {
        wallrigid.velocity = new Vector2(0, speedup);
        LiveScore.realscore = LiveScore.score + (speedup2);
        LiveScore.score =(LiveScore.realscore);
        if ((wallcoordinates.position.y - 15) > ((screenBounds.y)))
        {
            Destroy(this.gameObject);
        }
    }
}
