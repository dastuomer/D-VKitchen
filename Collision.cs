using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    
    void OnCollisionEnter(Collision collision)
    {
        // Check if the object collided with has the tag "Onion"
        if (collision.gameObject.CompareTag("Onion"))
        {
            
            collision.gameObject.GetComponent<Onion>().Chop();
        }
    }
}
