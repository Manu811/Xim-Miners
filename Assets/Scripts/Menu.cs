using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Menu : MonoBehaviour
{
    public GameObject toggle;
    public GameObject inputText;
    public GameObject dropdown;
    public GameObject emisorSonido;

    public bool playSound;

    private AudioSource source;

    public void Start()
    {
        source = emisorSonido.GetComponent<AudioSource>();
    }


    public void Jugar()
    {
        Debug.Log("Apretaste Jugar");
    }

   /*public void LeDisteClick()
    {
        bool activo = toggle.GetComponent<Toggle>().IsOn;
        Debug.Log("Cambio de opcion en toggle es: " +activo);
    }*/

    public void NombraTuMinero()
    {
        string nombre = inputText.GetComponent<InputField>().text;
        Debug.Log("EL NOMBRE DE TU MINERO ES:"+ nombre);
    }

    public void Update()
    {
        if(playSound && !source.isPlaying) //si le di click y no se esta reproduciendo
        source.Play();
    }

}
