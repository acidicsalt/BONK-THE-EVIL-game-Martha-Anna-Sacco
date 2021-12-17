using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2D : MonoBehaviour
{
    // Start is called before the first frame update
    bool isAttacking = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // pressing spacebar to hit
        if (Input.GetButtonDown("hitHammer") && !isAttacking)
        {
            isAttacking = true;

            //choose attack aniamtion to play. 
            // animator.Play("Character Animation"+index);
        }

    }
}
