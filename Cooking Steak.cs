using System.Collections;
using System.Collections.Generic;
using System;
using System.Threading;
using UnityEngine;

public class Steak : MonoBehaviour
{
    AudioManager audioManager;

    public ParticleSystem cookingSteak;

    public GameObject[] cookedSteak;

    private void Awake()

    {

        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();

    }
    public void CookSteak()
    {
        audioManager.PlaySFX(audioManager.FoodSizzling);

        gameObject.SetActive(false);


        foreach (GameObject piece in cookedSteak)
        {

            piece.SetActive(true);
        }
    }
}