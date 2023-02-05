using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    static GameController current;

    [SerializeField] private GameObject camara;

    private AudioSource musicaFondo;


    private void Start()
    {
        musicaFondo = camara.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
