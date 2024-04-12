using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("--------Audio Source--------")]
    [SerializeField] AudioSource musicSource;  // Reference to the AudioSource for music
    [SerializeField] AudioSource SFXSource;   // Reference to the AudioSource for sound effects


    [Header("--------Audio Clip--------")]
    public AudioClip LastLast;               // Audio clip for music
    public AudioClip COMMAS;                 // Audio clip for music
    public AudioClip Chopping;               // Audio clip for a chopping sound
    public AudioClip FoodSizzling;          // Audio clip for food sizzling
    public AudioClip Grabbing;             // Audio clip for grabbing something
    public AudioClip Oilpouring;          // Audio clip for pouring oil
    public AudioClip Oilsizzling;        // Audio clip for oil sizzling
    public AudioClip Puttingplateontable; // Audio clip for putting a plate on the table
    public AudioClip Turnonstove;       // Audio clip for turning on the stove
    public AudioClip Welcome;          // Audio clip for a welcome message
    public AudioClip Instructions;    // Audio clip for instructions
    public AudioClip step1;         // Audio clip for step 1 cooking process
    public AudioClip step2;        // Audio clip for step 2 cooking process
    public AudioClip step3;       // Audio clip for step 3 cooking process
    public AudioClip step4;      // Audio clip for step 4 cooking process
    public AudioClip step5;     // Audio clip for step 5 cooking process
    public AudioClip step6;    // Audio clip for step 6 cooking process
    public AudioClip step7;   // Audio clip for step 7 cooking process
    public AudioClip step8;  // Audio clip for step 8 cooking process

    // play a sound effect
    public void PlaySFX(AudioClip clip)
    {
        // Play the provided audio clip as a one-shot
        SFXSource.PlayOneShot(clip);
    }

    // Start is called before the first frame update
    private void Start()
    {
        // Set the musicSource clip to the "Welcome" audio clip
        musicSource.clip = Welcome;

        // Play the musicSource clip
        musicSource.Play();
    }
}
