using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinueScript : MonoBehaviour
{
    Canvas canvas;
    public static bool death = false;
    // Start is called before the first frame update
    void Start()
    {
        canvas = GetComponent<Canvas>();
        canvas.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (death == true)
        {
            Detector.pause = true;
            canvas.enabled = true;
            Time.timeScale = 0; //1 velocidad normal , 0 parado totalmente
        }

    }
    
    public void Continue()
    {
        Detector.vida = 3;
        Time.timeScale = 1f;
        canvas.enabled = false;
        death = false;
        Detector.death = false;
        Detector.pause = false;
    }
    public void Die()
    {
        Death.tacaño = true;
        Detector.death = true;
        Detector.pause = true;
        canvas.enabled = false;
    }
}
