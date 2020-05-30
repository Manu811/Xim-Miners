using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using CustomMessageBoxes;

public class Death : MonoBehaviour
{
    Canvas canvas;
    public static bool tacaño = false;
    int cont;

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
            if(cont == 0)
            {
                insertScore();
                cont++;
            }
            
            canvas.enabled = true;
            Time.timeScale = 0; //1 velocidad normal , 0 parado totalmente
            tacaño = false;
        }

    }

    public void Reiniciar()
    {
        SceneManager.LoadScene("Xim-Miners");
    }

    public void MenuButton()
    {
        SceneManager.LoadScene("Menu");
    }
    public void Leader()
    {
        LeaderScript.leader = true;
        canvas.enabled = false;
    }
    void insertScore()
    {
        string miner = Menu.nombre;
        Debug.Log(miner);

        int score = Score.scoreValue;
        Debug.Log(score);

        WWW www = new WWW("http://the-art-of-software-design.net/phpMyAdmin/scoreInsert.php?addMiner="+miner+"&addScore="+score);
            
      
    }
}
