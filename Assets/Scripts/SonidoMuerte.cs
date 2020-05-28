using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidoMuerte : MonoBehaviour
{
    public GameObject emisorU;
    private AudioSource source2;
    void Start()
    {
        
        source2 = emisorU.GetComponent<AudioSource>();

    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void sonidoMuerteXime(bool sonido)
    {
        if (sonido)
        {
            source2.Play();
        }
    }
}
