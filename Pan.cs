using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pan : MonoBehaviour
{

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Steak"))
        {

            collision.gameObject.GetComponent<Steak>().CookSteak();
        }
    }
}
