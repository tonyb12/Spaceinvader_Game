using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    public float speed = 10f;
    Rigidbody2D rigidbody;
    Animator animator;
    

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        Debug.Log("Start Method is used");
        animator = GetComponent<Animator>();
    }


    private void FixedUpdate(){

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector2 direction = new Vector2(horizontal, vertical);
        rigidbody.velocity = direction.normalized * speed;

        animator.SetBool("isFlyingLeft", (horizontal < 0 ));
        animator.SetBool("isFlyingRight", (horizontal > 0));
        animator.SetBool("isFlyingUp",(vertical > 0));      

    }

    
}
