using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
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
        Debug.Log(StatusEffect.vida);
        if (StatusEffect.vida == 0)
        {
            canvas.enabled = true;
            Time.timeScale = 0; //1 velocidad normal , 0 parado totalmente
        }

    }

    public void Reiniciar()
    {
        SceneManager.LoadScene("Xim-Miners");
        StatusEffect.vida = 3;
        Time.timeScale = 1;
        Score.scoreValue = 0;
        MetersScript.metersValue = 0;
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
}
