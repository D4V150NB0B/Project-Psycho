using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reproductor : MonoBehaviour
{
    public Audioclip[] clip;
    private AudioSource Reproductor;
    // Start is called before the first frame update
    void Start()
    {
        Reproductor = this.GetComponent<AudioSoucer>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
