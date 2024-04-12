using System.Collections;
using System.Collections.Generic;
using System;
using System.Threading;
using UnityEngine;

public class Steak : MonoBehaviour
{
    AudioManager audioManager; // reference to the AudioManager script

    public ParticleSystem cookingSteak; // reference to the particle system for cooking steak

    public GameObject[] cookedSteak; // array of cooked steak peices

    private void Awake()
    {
        // finding and geting a reference to the AudioManager
        // references the AudioManager componenet that is attached to a GameObject tagged as "Audio"
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    public void CookSteak()
    {
        // play the food sizzling sound effect using the AudioManager
        audioManager.PlaySFX(audioManager.FoodSizzling);

        // disable the raw steak GameObject
        gameObject.SetActive(false);

        // loop throughthe cookedSteak array
        foreach (GameObject piece in cookedSteak)
        {
            // activate each cooked steak piece GameObject
            piece.SetActive(true);
        }
    }
}
