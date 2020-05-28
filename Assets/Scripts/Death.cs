using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using CustomMessageBoxes;

public class Death : MonoBehaviour
{
    Canvas canvas;
    public static bool tacaño = false;
  

    // Start is called before the first frame update
    void Start()
    {
        canvas = GetComponent<Canvas>();
        canvas.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (tacaño == true)
        {
            canvas.enabled = true;
            Time.timeScale = 0; //1 velocidad normal , 0 parado totalmente
        }

    }

    public void Reiniciar()
    {
        SceneManager.LoadScene("Xim-Miners");
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
}
