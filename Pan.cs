using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pan : MonoBehaviour
{
    // this is called when a collision occurs with the pan 
    void OnCollisionEnter(Collision collision)
    {
        // checking if its the steak
        if (collision.gameObject.CompareTag("Steak"))
        {
            // if it is the steak
            // call the Cook.Steak method (which is what changes the raw steak to the cooked steak) 
            collision.gameObject.GetComponent<Steak>().CookSteak();
        }
    }
}
