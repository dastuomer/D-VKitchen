using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    //When a collision occurs this method is called.
    void OnCollisionEnter(Collision collision)
    {
        // Check if the object collided with, has the tag "Onion".
        if (collision.gameObject.CompareTag("Onion"))
        {

            //If the collided object has the tag "Onion", call the chop method.
            collision.gameObject.GetComponent<Onion>().Chop();
        }
    }
}
