using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScreen : MonoBehaviour
{
    public Text pointText; 
    public ProductsHit hit;
    private bool active = false;

    public void setactive(bool _active)
    {
        active = _active;
    }

    void Update ()
    {
        int score = 0;
        Debug.Log("active is:");
        Debug.Log(active);
        gameObject.SetActive(active);
        pointText.text = score.ToString() + " POINTS"; 
    }

}