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
        Reproductor.clip = Audios[];
        Reproductor.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
