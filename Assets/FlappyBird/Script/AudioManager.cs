using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    public AudioSource sfxMusic;
    public AudioSource backGroundMusic;
    

    public AudioClip jump;
    public AudioClip gameOver;
    public AudioClip score;
    public AudioClip button;

    public AudioClip background;
    public AudioClip currentAudioClip { get; private set; }

    private void Start()
    {
        BGM(background);
    }
    public void PlaySFX(AudioClip audio)
    {
        currentAudioClip = audio;
        sfxMusic.PlayOneShot(currentAudioClip);
    }
    public void BGM(AudioClip audio)
    {
        backGroundMusic.clip = audio;
        backGroundMusic.loop = true;
        backGroundMusic.Play();
    }
}
