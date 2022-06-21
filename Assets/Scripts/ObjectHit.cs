using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) // Works when a collision occurs.
    {
        if(other.gameObject.tag == "Player")
        {
        GetComponent<MeshRenderer>().material.color = Color.red;
        gameObject.tag = "Hit"; // This time because I haven't specified other in front of it, it's going to use the game object tag that belongs to whichever object this script is on, if that makes sense.
        }
    }
}
