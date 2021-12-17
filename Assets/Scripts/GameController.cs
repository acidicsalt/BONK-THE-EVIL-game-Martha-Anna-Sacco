using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameOverScreen GameOverScreen;
    int maxPlatform = 1;
    
    // public void Update ()
    // {
    //     Debug.Log(GameOverScreen.gameObject.transform.childCount);

    // }


    public void GameOver()
    {
        // GameOverScreen.Setup(maxPlatform);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Food") 
        {
            //Load Game Over if Onion-Man hits food products.
            SceneManager.LoadScene ("GameOverScreen");
        }
    }
}


