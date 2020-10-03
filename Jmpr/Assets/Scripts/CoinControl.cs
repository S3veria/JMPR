using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinControl : MonoBehaviour
{

    public static float numberofcoins=0;
    public Transform coinposition;
    public static float plusthisround;
    private Vector2 screenBounds;
    public Rigidbody2D rigidcoin;
    public static float coinmultiplier = 1.0f;

    void Start()
    {
        numberofcoins = PlayerPrefs.GetFloat("NumberofCoins", numberofcoins);
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));

    }

    // ------------------------------------------------- Update --------------------------------------------------------------
    void Update()
    {
        rigidcoin.velocity = new Vector2(0, ACObstacle.speedup);
        if ((coinposition.position.y - 10) > ((screenBounds.y)))
        {
            Destroy(this.gameObject);
        }
    }

    // ------------------------------------------------- End Update --------------------------------------------------------------




    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            plusthisround=plusthisround + 1;
            Debug.Log(numberofcoinss.numbcoins);
            Destroy(this.gameObject);

        }


    }
}
