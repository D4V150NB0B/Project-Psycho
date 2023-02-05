using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChatTemplateRobert : MonoBehaviour
{
    public Button button1;
    public Button button2;
    public Button button3;
    public GameObject canva1;
    public GameObject canva2;
    public GameObject canva3;

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
        Debug.Log("Boton1presionado");
        Instantiate(canva1, new Vector3(0, 0, 0), Quaternion.identity);
        Destroy(transform.gameObject.GetComponentInParent<Canvas>().gameObject);
    }
    public void Button2Pressed()
    {
        
        Instantiate(canva2, new Vector3(0, 0, 0), Quaternion.identity);
        Destroy(transform.gameObject.GetComponentInParent<Canvas>().gameObject);
    }
    public void Button3Pressed()
    {
        Instantiate(canva3, new Vector3(0, 0, 0), Quaternion.identity);
        Destroy(transform.gameObject.GetComponentInParent<Canvas>().gameObject);
    }
}
