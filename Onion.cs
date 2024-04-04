using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Onion : MonoBehaviour
{
    // Particle system for chopping effect
    public ParticleSystem chopParticles;

    // Small onion pieces
    public GameObject[] onionPieces;

    
    public void Chop()
    {
        // Play chopping particle effect if assigned
        //if (chopParticles != null)
        //{
        // chopParticles.Play();
       // }

        // Deactivate the main onion object
        gameObject.SetActive(false);

        // Activate chopped onion pieces
        foreach (GameObject piece in onionPieces)
        {
            piece.SetActive(true);
        }

        

        // Destroy the onion object after a delay
        Destroy(gameObject, 1f);
    }

    
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Knife"))
        {
            Chop();
        }
    }
}