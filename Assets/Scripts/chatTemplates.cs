using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class chatTemplates : MonoBehaviour
{
    public Button button1;
    public Button button2;
    public Button button3;
    public GameObject canva1;

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
        Debug.Log(Stats.singleton.estres);
        Instantiate(canva1, new Vector3(0, 0, 0), Quaternion.identity);
        Destroy(transform.gameObject.GetComponentInParent<Canvas>().gameObject);
    }
    public void Button2Pressed()
    {
        Debug.Log(Stats.singleton.confianza);
    }
    public void Button3Pressed()
    {
        Debug.Log(Stats.singleton.motivacion);
    }
}
