using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Control : MonoBehaviour
{
    public float border_lim;
    public float speed = 10f;
    public KeyCode moveUp = KeyCode.W;
    public KeyCode moveDown = KeyCode.S;
    public KeyCode moveLeft = KeyCode.A;
    public KeyCode moveRight = KeyCode.D;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void border()
    {
        var pos = transform.position;
        {
            if (pos.x > 0)
            {
                if (pos.x < border_lim)
                {
                    pos.x = border_lim;
                }
                if(pos.x > 28)
                {
                    pos.x = 28;
                }
            }
            else if (pos.x < 0)
            {
                if (pos.x > border_lim)
                {
                    pos.x = border_lim;
                }
                if (pos.x < -28)
                {
                    pos.x = -28;
                }
            }
            if(pos.y > 16)
            {
                pos.y = 16;
            }
            else if (pos.y < -16) 
            {
                pos.y = -16;
            }
        }

        transform.position = pos;
    }
    // Update is called once per frame
    void Update()
    {
        border();
        var vel = rb.velocity;
        if (Input.GetKey(moveUp))
        {
            vel.y = speed;
        }
        else if (Input.GetKey(moveDown))
        {
            vel.y = -speed;
        }
        else if (Input.GetKey(moveLeft))
        {
            vel.x = -speed;
        }
        else if (Input.GetKey(moveRight))
        {
            vel.x = speed;
        }
        else
        {
            vel.y = 0;
            vel.x = 0;
        }
        rb.velocity = vel;

    }
}