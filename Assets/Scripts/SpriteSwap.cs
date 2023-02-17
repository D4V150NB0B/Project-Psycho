using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteSwap : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite sNeutro;
    public Sprite sAlegre;
    public Sprite sDemacrado;
    public Sprite sFaltaDeConfianza;
    public Sprite sOrgullo;
    public Sprite sRelajado;
    public Sprite sTristeza;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer.sprite = sNeutro;
    }

    // Update is called once per frame
    void Update()
    {
        
        if ((Stats.singleton.confianza > Stats.singleton.estres) && (Stats.singleton.confianza > Stats.singleton.tension) && (Stats.singleton.confianza > Stats.singleton.motivacion) && Stats.singleton.confianza > 6)
        {
            spriteRenderer.sprite = sOrgullo;
        }
        if ((Stats.singleton.estres > Stats.singleton.confianza) && (Stats.singleton.estres > Stats.singleton.tension) && (Stats.singleton.estres > Stats.singleton.motivacion) && Stats.singleton.estres > 6)
        {
            spriteRenderer.sprite = sDemacrado;
        }
        if ((Stats.singleton.tension > Stats.singleton.confianza) && (Stats.singleton.tension > Stats.singleton.estres) && (Stats.singleton.tension > Stats.singleton.motivacion) && Stats.singleton.tension > 6)
        {
            spriteRenderer.sprite = sTristeza;
        }
        
        if ((Stats.singleton.motivacion > Stats.singleton.confianza) && (Stats.singleton.motivacion > Stats.singleton.estres) && (Stats.singleton.motivacion > Stats.singleton.tension) && Stats.singleton.motivacion > 6)
        {
            spriteRenderer.sprite = sAlegre;
        }
        else
        {
            spriteRenderer.sprite = sNeutro;
        }

        if ((Stats.singleton.motivacion < 6)&& (Stats.singleton.confianza < 6)&& (Stats.singleton.estres < 6)&& (Stats.singleton.tension < 6))
        {
            if ((Stats.singleton.confianza == Stats.singleton.estres) || (Stats.singleton.confianza == Stats.singleton.tension) ||
            (Stats.singleton.confianza == Stats.singleton.motivacion) || (Stats.singleton.tension == Stats.singleton.estres) || (Stats.singleton.motivacion == Stats.singleton.estres) || (Stats.singleton.tension == Stats.singleton.motivacion))
            {
                spriteRenderer.sprite = sNeutro;
            }
            else
            {
                spriteRenderer.sprite = sRelajado;
            }
                
        }

        if ((Stats.singleton.confianza < Stats.singleton.estres) && (Stats.singleton.confianza < Stats.singleton.tension) && (Stats.singleton.confianza < Stats.singleton.motivacion) && Stats.singleton.confianza < 6)
        {
            spriteRenderer.sprite = sFaltaDeConfianza;
        }
    }
}

