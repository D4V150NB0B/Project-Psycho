using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour
{
    public static Stats singleton;
    public int confianza = 5;
    public int motivacion = 5;
    public int tension = 5;
    public int estres = 5;

    private void Awake()
    {
        if (singleton != null)
        {
            Destroy(gameObject);
        }
        else
        {
            singleton = this;
        }
    }
}
