using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; 

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        
        float horizontalInput = Input.GetAxis("Horizontal");

       
        Vector2 movement = new Vector2(horizontalInput, 0f);

       
        rb.velocity = movement * moveSpeed;
    }
}

