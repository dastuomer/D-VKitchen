using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("--------Audio Source--------")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;


    [Header("--------Audio Clip--------")]
    public AudioClip LastLast;
    public AudioClip COMMAS;
    public AudioClip Chopping;
    public AudioClip FoodSizzling;
    public AudioClip Grabbing;
    public AudioClip Oilpouring;
    public AudioClip Oilsizzling;
    public AudioClip Puttingplateontable;
    public AudioClip Turnonstove;
    public AudioClip Welcome;

public void PlaySFX(AudioClip clip)
{
    SFXSource.PlayOneShot(clip);
}
    
    
}
