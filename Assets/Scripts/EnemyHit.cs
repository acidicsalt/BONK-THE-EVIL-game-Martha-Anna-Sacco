using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHit : MonoBehaviour
// When Onion-Man hits enemy
// The player wins
{
    [SerializeField]
    private bool _enemyHit = true;

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log($"Hit: {other.name}");
        _enemyHit = (other.gameObject.tag =="Player");
    }
}
