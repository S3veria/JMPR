using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ACObstacle : MonoBehaviour
{

    public Rigidbody2D obstaclerigid;
    public static float speedup = 4.0f;
    private Vector2 screenBounds;
    public Transform acoordinates;
    public float obstaclespawntime=1.0f;




    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
      

    }


    void Update()
    {
        obstaclerigid.velocity = new Vector2(0, speedup);
        if ((acoordinates.position.y -10) > ((screenBounds.y)))
        {
            Destroy(this.gameObject);
        }

    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<Jump>().playerhp -= 1;
            Destroy(this.gameObject);
            SceneManager.LoadScene("Game Over");
        }

        
    }
}
