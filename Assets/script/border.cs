using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class border : MonoBehaviour
{
    private Rigidbody2D rb;
    public float border_lim;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        {
            var pos = transform.position;
            if (pos.x > border_lim)
            {
                pos.x = border_lim;
            };
            Debug.Log("Pos" + pos.x);
        }
    }
}
