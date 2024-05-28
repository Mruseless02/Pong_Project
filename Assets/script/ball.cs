using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody2D rb;
    public float Maxspeed = 10f;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Invoke("GoBall", 2);
    }
    void GoBall()
    {
        float rand = Random.Range(0, 2);

        if (rand > 1)
        {
            rb.AddForce(new Vector2(20, 0));
        }
        else if (rand < 1)
        {
            rb.AddForce(new Vector2(-20, 0));
        }
    }

    void resetBall()
    {
        rb.velocity = Vector2.zero;
        transform.position = Vector2.zero;
    }

    void resetGame()
    {
        resetBall();
        Invoke("GoBall", 1);
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.collider.CompareTag("Player"))
        {
            {
                Vector2 vel;
                vel.x = rb.velocity.x;
                vel.y = (rb.velocity.y / 2) + (coll.collider.attachedRigidbody.velocity.y / 3);
                rb.velocity = vel;
            }
        }
    }

    void Update()
    {
        if(rb.velocity.magnitude > Maxspeed)
        {
            rb.velocity = Vector2.ClampMagnitude(rb.velocity, Maxspeed);
        }
    }
}