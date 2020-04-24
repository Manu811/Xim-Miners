using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PAUSAR : MonoBehaviour
{
    bool active;
    Canvas canvas;

    // Start is called before the first frame update
    void Start()
    {
        canvas = GetComponent<Canvas>();
        canvas.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            active = !active;
            canvas.enabled = active;
            Time.timeScale = (active) ? 0 : 1f; //1 velocidad normal , 0 parado totalmente
        }
    }

    public void Pausa()
    {
        Debug.Log("Apretaste Pausa");
        SceneManager.LoadScene("Pausa");

    }
}
