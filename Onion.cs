using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Onion : MonoBehaviour
{
    AudioManager audioManager;
    // Particle system for chopping effect
    public ParticleSystem chopParticles;

    // Small onion pieces
    public GameObject[] onionPieces;
    
    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }
    
    
    public void Chop()
    {
        audioManager.PlaySFX(audioManager.Chopping);
        
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
