using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ProductsHit : MonoBehaviour
// When Onion-Man hits food products
// The player looses and game over.
{
    [SerializeField]
    public bool _productHit = false;

    void OnTriggerEnter2D(Collider2D other)
    {
        _productHit = true;
        Debug.Log("Hello");
            SceneManager.LoadScene ("GameOverScreen");
    }

}