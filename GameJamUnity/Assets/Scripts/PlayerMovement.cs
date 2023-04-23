using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    //Iniciar Variaveis
    [SerializeField] private float speed;
    //[SerializeField] private float speedMultiplier;

    private bool upCommand;
    private bool downCommand;
    private bool leftCommand;
    private bool rightCommand;

    private Rigidbody2D rb;






    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            upCommand = true;
        }
        if (Input.GetKey(KeyCode.S))
        {
            downCommand = true;
        }
        if (Input.GetKey(KeyCode.D))
        {
            leftCommand = true;
        }
        if (Input.GetKey(KeyCode.A))
        {
            rightCommand = true;
        }
    }

    private void FixedUpdate()
    {
        if(upCommand)
        {
            rb.velocity = new Vector2(rb.velocity.x, speed);
            upCommand = false;
        }
        if (downCommand)
        {
           rb.velocity = new Vector2(rb.velocity.x, -speed);
            downCommand = false;
        }
        if (leftCommand)
        {
            rb.velocity = new Vector2(speed, rb.velocity.y);
            leftCommand = false;
            transform.rotation = Quaternion.Euler(0,0,0);

        }
        if (rightCommand)
        {
            rb.velocity = new Vector2(-speed, rb.velocity.y);
            rightCommand = false;
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        
    }
}
