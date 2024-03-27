using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;

public class goal : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D hitinfo)
    {
        if(hitinfo.name == "puck")
        {
            string wallname = transform.name;
            // manggil metchode score di game manager
            GameManager.Instance.score(wallname);
            //manggil restart game dari ball.cs
            hitinfo.gameObject.SendMessage("RestartGame", 1.0f, SendMessageOptions.RequireReceiver);
        }
    }
}
