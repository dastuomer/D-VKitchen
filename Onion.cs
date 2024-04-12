using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Onion : MonoBehaviour
{
 // Reference to the AudioManager for playing sounds
    AudioManager audioManager; 

    // Particle system for chopping effect
    public ParticleSystem chopParticles;  
    
    // Small onion pieces, this is an array of GameObjects representing small onion pieces
    public GameObject[] onionPieces; 

    private void Awake()
    {
        // Find and assign the AudioManager component from a GameObject with the "Audio" tag
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }
    
    // Method to chop the onion
    public void Chop()
    {
        // Play the chopping sound effect
        audioManager.PlaySFX(audioManager.Chopping);

        // Deactivate the main onion object
        gameObject.SetActive(false);

        // Activate each chopped onion piece
        foreach (GameObject piece in onionPieces)
        {
            piece.SetActive(true);
        }

        // Destroy the onion object after a delay of 1 second
        Destroy(gameObject, 1f);
    }

    // When a collision occurs this method is called.
    void OnCollisionEnter(Collision collision)
    {
        // Check if the colliding GameObject has the tag "Knife"
        if (collision.gameObject.CompareTag("Knife"))
        {
            // If the colliding GameObject has the tag "Knife", call the Chop() method to chop the onion
            Chop();
        }
    }
}
