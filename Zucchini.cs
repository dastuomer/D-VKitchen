using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zucchini : MonoBehaviour
{
    AudioManager audioManager; // reference to the AudioManager script

    // creating chopping effect
    public ParticleSystem chopParticles;

    // small zucchini pieces
    public GameObject[] zucchiniPieces;

    private void Awake()
    {
        // finding and getting the AudioManager component attached to a GameObject tagged as "Audio"
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    public void ChopZucchini()
    {
        // play the chopping sound
        audioManager.PlaySFX(audioManager.Chopping);

        // deactivate the whole zucchini object
        gameObject.SetActive(false);

        // activate  the chopped zucchini pieces
        foreach (GameObject piece in zucchiniPieces)
        {
            // playing the chopping sound effect for each piece
            audioManager.PlaySFX(audioManager.Chopping);
            // activate each GameObject representing a chopped zucchini piece
            piece.SetActive(true);
        }

        // destroy the GameObject after 1 second
        Destroy(gameObject, 1f);
    }

    void OnCollisionEnter(Collision collision)
    {
        // check if it's colliding with the knife
        if (collision.gameObject.CompareTag("Knife"))
        {
            // if it is the knife, chop the zucchini
            ChopZucchini();
        }
    }
}
