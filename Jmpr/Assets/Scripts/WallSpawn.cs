using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSpawn : MonoBehaviour
{
    public GameObject basicwall;
    private float x, y, x2,deletey;
    private float ycoordinate;
    private bool keepspawning = true;
    // Start is called before the first frame update
    void Start()
    {
        x = 3.265262f;
        x2 = -9.411916f;
        y = -9f;
        deletey = -2.5f;
        StartCoroutine(somecoroutine());
        GameObject walli = Instantiate(basicwall) as GameObject;
        walli.transform.position = new Vector3(-2.82f, 3.684004f, 0f);
        GameObject walli2 = Instantiate(basicwall) as GameObject;
        walli2.transform.position = new Vector3(-2.82f, -1.029004f, 0f);
        GameObject walli3 = Instantiate(basicwall) as GameObject;
        walli3.transform.position = new Vector3(-2.82f, -6.12f, 0f);
        GameObject wallr = Instantiate(basicwall) as GameObject;
        wallr.transform.position = new Vector3(2.89f, 3.684004f, 0f);
        GameObject wallr2 = Instantiate(basicwall) as GameObject;
        wallr2.transform.position = new Vector3(2.89f, -1.029004f, 0f);
        GameObject wallr3 = Instantiate(basicwall) as GameObject;
        wallr3.transform.position = new Vector3(2.89f, -6.12f, 0f);


    }

    // Update is called once per frame
    void Update()
    {
       
        if (ycoordinate==deletey)
        {
            spawnwalls();
        }
    }

    void spawnwalls()
    {
        GameObject wall = Instantiate(basicwall) as GameObject;
        wall.transform.position = new Vector3(-2.82f, y, 0f);
        ycoordinate = wall.transform.position.y;
        GameObject wall2 = Instantiate(basicwall) as GameObject;
        wall2.transform.position = new Vector3(2.89f, y, 0f);
    }

    IEnumerator somecoroutine()
    {
        while (keepspawning)
        {
            yield return new WaitForSeconds(0.5f);
            spawnwalls();
        }
    }
}
