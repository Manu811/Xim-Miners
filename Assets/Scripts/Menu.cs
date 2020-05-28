using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Menu : MonoBehaviour
{
 
   public GameObject inputText;
   public GameObject status;

    //public GameObject emisorSonido;

    public bool playSound;
    public static string nombre;
    private AudioSource source;
    GameObject inGameToggle;

    public void Start()
    {
        // source = emisorSonido.GetComponent<AudioSource>();
        inGameToggle = GameObject.Find("Status2");
        Debug.Log(inGameToggle);
        status.GetComponent<Toggle>().isOn = !inGameToggle;
    }


    public void Jugar()
    {
        Debug.Log("Apretaste Jugar");
        SceneManager.LoadScene("Xim-Miners");

    }

    public void NombraTuMinero()
    {
       
            nombre = inputText.GetComponent<InputField>().text;
            Debug.Log("EL NOMBRE DE TU MINERO ES:" + nombre);
        
       
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
    public void Regresar()
    {
        SceneManager.LoadScene("Menu");
        Debug.Log("¿Regresar?");
    }
    public void Sound()
    {
        bool estado = status.GetComponent<Toggle>().isOn;
        Debug.Log("Con Sonido:"+estado);
        //gameObject.SendMessage("setSound", estado);
        if (estado == false)
        {
            AudioListener.volume = 0;
        }
        if (estado == true)
        {
            AudioListener.volume = 1;
        }

    }
   /* public void Update()
    {
      
    }*/

}
