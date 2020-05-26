using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Die : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale              = 1f;
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
