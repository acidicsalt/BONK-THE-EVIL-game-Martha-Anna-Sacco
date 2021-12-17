using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnionMan : MonoBehaviour
{
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    // Animating OnionMan
    if (Input.GetButtonDown("Jump"))
    {
        animator.SetTrigger("Hit");
    }

    }
}
