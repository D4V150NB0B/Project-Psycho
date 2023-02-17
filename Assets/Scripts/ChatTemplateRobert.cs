using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChatTemplateRobert : MonoBehaviour
{
    public Button button1;
    public Button button2;
    public Button button3;
    public GameObject canva1;
    public GameObject canva2;
    public GameObject canva3;
    public int confianza1 = 0;
    public int motivacion1 = 0;
    public int tension1 = 0;
    public int estres1 = 0;
    public int confianza2 = 0;
    public int motivacion2 = 0;
    public int tension2 = 0;
    public int estres2 = 0;
    public int confianza3 = 0;
    public int motivacion3 = 0;
    public int tension3 = 0;
    public int estres3 = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Button1Pressed()
    {
        Stats.singleton.confianza += confianza1;
        Stats.singleton.motivacion += motivacion1;
        Stats.singleton.tension += tension1;
        Stats.singleton.estres += estres1;
        
        Instantiate(canva1, new Vector3(0, 0, 0), Quaternion.identity);
        Destroy(transform.gameObject.GetComponentInParent<Canvas>().gameObject);
    }
    public void Button2Pressed()
    {

        Stats.singleton.confianza += confianza2;
        Stats.singleton.motivacion += motivacion2;
        Stats.singleton.tension += tension2;
        Stats.singleton.estres += estres2;
       
        Instantiate(canva2, new Vector3(0, 0, 0), Quaternion.identity);
        Destroy(transform.gameObject.GetComponentInParent<Canvas>().gameObject);
    }
    public void Button3Pressed()
    {

        Stats.singleton.confianza += confianza3;
        Stats.singleton.motivacion += motivacion3;
        Stats.singleton.tension += tension3;
        Stats.singleton.estres += estres3;
        
        Instantiate(canva3, new Vector3(0, 0, 0), Quaternion.identity);
        Destroy(transform.gameObject.GetComponentInParent<Canvas>().gameObject);
    }

    public void CambiarScenaTransitionIntro()
    {
        SceneManager.LoadScene("TransitionIntro");
    }
    public void CambiarScenaMenuDeInicio()
    {
        SceneManager.LoadScene("MenuDeInicio");
    }
    public void CambiarScenaMainGame()
    {
        SceneManager.LoadScene("MainGame");
    }
    public void CambiarScenaFinalTension()
    {
        SceneManager.LoadScene("FinalTension");
    }
    public void CambiarScenaFinalBueno()
    {
        SceneManager.LoadScene("FinalBueno");
    }
    public void CambiarScenaFinalEstres()
    {
        SceneManager.LoadScene("FinalEstres");
    }
    public void CambiarScenaFinalMotivacion()
    {
        SceneManager.LoadScene("FinalMotivacion");
    }
    public void CambiarScenaFinalMalo()
    {
        SceneManager.LoadScene("FinalMalo");
    }
    public void CambiarScenaFinalConfianza()
    {
        SceneManager.LoadScene("FinalConfianza");
    }

}
