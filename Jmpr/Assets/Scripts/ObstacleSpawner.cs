using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject AC1;
    public GameObject AC2;
    public GameObject AC3;
    private int chance, leftorright;
    public static float obstaclespawntime = 1.0f;
    private Vector2 screenBounds;
    private float x1, y1, x2, y2;
    private float xx, xx2;
    bool keepspawning = true;
    private float coinx, coinx2, coiny;
    public GameObject coin;

    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(TimedSpawn());
        x1 = -1.66f;
        y1 = -6.5f;
        x2 = 1.73f;
        y2 = y1;
        xx = -1.38f;
        xx2 = 1.44f;
        coinx = -1.77f;
        coinx2 = 1.75f;
        coiny = -6.5f;



    }

    private void SpawnAC()
    {
        
        chance = Random.Range(0, 3);
        leftorright = Random.Range(0, 2);
        if (chance == 0)
        {

            if (leftorright == 0)
            {
                GameObject obstacle = Instantiate(AC1) as GameObject;
                obstacle.transform.position = new Vector2(x1, y1);
                obstacle.transform.localScale = new Vector3(3f, 3f, 0);
                Vector3 AScale = obstacle.transform.localScale;
                AScale.y = 3;
                transform.localScale = AScale;
                GameObject newcoin = Instantiate(coin) as GameObject;
                newcoin.transform.position = new Vector2(coinx2, coiny);
                

            }

            else if (leftorright == 1)
            {
                GameObject obstacle = Instantiate(AC1) as GameObject;
                obstacle.transform.position = new Vector2(x2, y2);
                obstacle.transform.localScale = new Vector3(3f, -3f, 0);
                GameObject newcoin = Instantiate(coin) as GameObject;
                newcoin.transform.position = new Vector2(coinx, coiny);


            }

        }

        else if (chance == 1)
        {

            if (leftorright == 0)
            {
                GameObject obstacle = Instantiate(AC2) as GameObject;
                obstacle.transform.position = new Vector2(x1, y1);
                obstacle.transform.localScale = new Vector3(3f, 3f, 0);
                GameObject newcoin = Instantiate(coin) as GameObject;
                newcoin.transform.position = new Vector2(coinx2, coiny);

            }

            else if (leftorright == 1)
            {
                GameObject obstacle = Instantiate(AC2) as GameObject;
                obstacle.transform.position = new Vector2(x2, y2);
                obstacle.transform.localScale = new Vector3(3f, -3f, 0);
                GameObject newcoin = Instantiate(coin) as GameObject;
                newcoin.transform.position = new Vector2(coinx, coiny);
            }

        }

        else if (chance == 2)
        {
            if (leftorright == 0)
            {
                GameObject obstacle = Instantiate(AC3) as GameObject;
                obstacle.transform.position = new Vector2(xx, y1);
                obstacle.transform.localScale = new Vector3(2.5f, 2.5f, 0);
                GameObject newcoin = Instantiate(coin) as GameObject;
                newcoin.transform.position = new Vector2(coinx2, coiny);
            }

            else if (leftorright == 1)
            {
                GameObject obstacle = Instantiate(AC3) as GameObject;
                obstacle.transform.position = new Vector2(xx2, y2);
                obstacle.transform.localScale= new Vector3 (-2.5f,2.5f,0);
                GameObject newcoin = Instantiate(coin) as GameObject;
                newcoin.transform.position = new Vector2(coinx, coiny);
            }

        }

    }


    // Update is called once per frame
    void Update()
    {
        if (LiveScore.score >= 2500f)
        {
            ACObstacle.speedup = 6.0f;
            WallScroll.speedup = 6.0f;
            WallScroll.speedup2 = 0.075f;
            obstaclespawntime = 0.8f;
            if (LiveScore.score >= 10000)
            {
                ACObstacle.speedup = 8f;
                WallScroll.speedup2 = 0.1f;
                WallScroll.speedup = 8f;
                obstaclespawntime = 0.6f;
            }
        }
    }


    IEnumerator TimedSpawn()
    {
        while (keepspawning)
        {
            yield return new WaitForSeconds(obstaclespawntime);
            SpawnAC();
        }
    }


}
