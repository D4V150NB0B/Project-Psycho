using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reproductorcontroller : MonoBehaviour
{
    public AudioClip[] Audios;
    private AudioSource Reproductor;
    // Start is called before the first frame update
    void Start()
    {
        Reproductor = this.GetComponent<AudioSource>();
        
    }
    public void PlayButtonSound()
    {
        Reproductor.clip = Audios[19];
        Reproductor.PlayOneShot(Reproductor.clip);
        Reproductor.Play();
    }

    public void OptionButtonSound()
    {
        Reproductor.clip = Audios[17];
        Reproductor.PlayOneShot(Reproductor.clip);
        Reproductor.Play();
    }
    public void SoundButtonChat()
    {
        Reproductor.clip = Audios[21];
        Reproductor.PlayOneShot(Reproductor.clip);
        Reproductor.Play();
    }

    public void QuitButtonSound()
    {
        Reproductor.clip = Audios[20];
        Reproductor.PlayOneShot(Reproductor.clip);
        Reproductor.Play();
    }

    public void GameOverButtonSound()
    {
        Reproductor.clip = Audios[18];
        Reproductor.PlayOneShot(Reproductor.clip);
        Reproductor.Play();
    }
}


