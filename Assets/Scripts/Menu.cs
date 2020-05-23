using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Menu : MonoBehaviour
{
 
    public GameObject inputText;

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
        SceneManager.LoadScene("Xim-Miners");

    }

    public void NombraTuMinero()
    {
        string nombre = inputText.GetComponent<InputField>().text;
        Debug.Log("EL NOMBRE DE TU MINERO ES:"+ nombre);
    }

    public void Salir()
    {
        Application.Quit();
        Debug.Log("SALIR");
    }
    public void Instrucciones()
    {
        SceneManager.LoadScene("ComoJugar");
        Debug.Log("¿Como jugar?");
    }

    public void Update()
    {
        if(playSound && !source.isPlaying) //si le di click y no se esta reproduciendo
        source.Play();
    }

}
