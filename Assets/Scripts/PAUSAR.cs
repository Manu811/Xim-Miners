using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class PAUSAR : MonoBehaviour
{
    bool active;
    Canvas canvas;
    //public GameObject status;
    //GameObject inGameToggle;

    // Start is called before the first frame update
    void Start()
    {
        canvas = GetComponent<Canvas>();
        canvas.enabled = false;
       // inGameToggle = GameObject.Find("Status");
        //Debug.Log(inGameToggle);
        //status.GetComponent<Toggle>().isOn = !inGameToggle;
    }

    // Update is called once per frame
    void Update()
    {
        if (!Detector.death)
        {
            if (Input.GetKeyDown("space"))
            {
                active = !active;
                if (active)
                {
                    Detector.pause = true;
                }
                else
                {
                    Detector.pause = false;
                }
                canvas.enabled = active;
                Time.timeScale = (active) ? 0 : 1f; //1 velocidad normal , 0 parado totalmente
            }
        }
    }

    public void Pausa()
    {
        Debug.Log("Apretaste Pausa");
        SceneManager.LoadScene("Pausa");

    }

   /* public void Sound()
  {
      bool estado2 = status.GetComponent<Toggle>().isOn;
      Debug.Log("Con Sonido:" + estado2);
      //gameObject.SendMessage("setSound", estado);
      if (estado2 == false)
      {
          AudioListener.volume = 0;
      }
      if (estado2 == true)
      {
          AudioListener.volume = 1;
      }

  }*/
}
