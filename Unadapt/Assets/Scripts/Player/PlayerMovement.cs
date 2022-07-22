using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D body;

    float horizontal;
    float vertical;

    public float runSpeed = 20.0f;

    void Start ()
    {
    body = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
    // Gives a value between -1 and 1
    horizontal = Input.GetAxisRaw("Horizontal"); // -1 is left
    vertical = Input.GetAxisRaw("Vertical"); // -1 is down
    }

    void FixedUpdate()
    {
    if (horizontal != 0 && vertical != 0) // Check for diagonal movement and remove it
    {
        horizontal = 0;
        vertical = 0;
    } 

    if(horizontal >= 0)
    {
        GetComponent<SpriteRenderer>().flipX = false;
    }
    else
    {
        GetComponent<SpriteRenderer>().flipX = true;
    }

    body.velocity = new Vector2(horizontal * runSpeed, vertical * runSpeed);
    }
}
