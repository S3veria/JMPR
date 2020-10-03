using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

   public void GoToGameOver()
    {
        SceneManager.LoadScene("Game Over");

    }

    public void RestartGame()
    {
        SceneManager.LoadScene("Main Game Scene");
        LiveScore.score = 0f;
        WallScroll.speedup = 4.0f;
        WallScroll.speedup2 = 0.05f;
        ACObstacle.speedup = 4.0f;
        ObstacleSpawner.obstaclespawntime = 1.0f;
        
    }

    public void GoHome()
    {
        SceneManager.LoadScene("Main Menu");
    }

}
