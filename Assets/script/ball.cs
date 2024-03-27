using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Invoke("GoBall", 2);
    }
    void GoBall()
    {
        float rand = Random.Range(0,2);

        if(rand < 1)
        {
            rb.AddForce(new Vector2(20,- 15));
        }
        else
        {
            rb.AddForce(new Vector2(-20, -15));
        }
    }

    void ResetBall()
    {
        rb.velocity = Vector2.zero;
        transform.position = Vector2.zero;
    }

    void ResetGame()
    {
        ResetBall();
        Invoke("GoBall", 1);
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.collider.CompareTag("Player"))
        {
            Vector2 vel;
            vel.x = rb.velocity.x;
            vel.y = (rb.velocity.y / 2) + (coll.collider.attachedRigidbody.velocity.y / 3);
            rb.velocity = vel;
        }
        if (coll.collider.CompareTag("Goal"))
        {
            ResetBall();
        }
    }
}
