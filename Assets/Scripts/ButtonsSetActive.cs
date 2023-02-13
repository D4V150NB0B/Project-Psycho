using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsSetActive : MonoBehaviour
{
    public GameObject thisObject;
    public TextAnimated textAnim;
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    bool setted = false;
    int characters;
    float timeBtwen;

    float tiempoPaciente;
    float tiempoParaRespuestas = 10;
    // Start is called before the first frame update
    IEnumerator Start()
    {
        yield return null;

        characters = textAnim.charCount;
        timeBtwen = textAnim.timeBtwnChars;
        //Debug.Log(characters);

        tiempoPaciente = characters * timeBtwen;
        //Debug.Log(tiempoPaciente);

        tiempoParaRespuestas = Time.time + tiempoPaciente;
        //Debug.Log(tiempoParaRespuestas);
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= tiempoParaRespuestas && setted == false)
        {
            ButtonsShow();
            //Debug.Log("ButtonShowed");
            setted = true;
        }
    }

    void ButtonsShow()
    {
        if (button1 != null)
        {
            button1.SetActive(true);

        }
        if (button2 != null)
        {
            button2.SetActive(true);

        }
        if (button3 != null)
        {
            button3.SetActive(true);

        }
    }
  
}
