using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalScore : MonoBehaviour
{
    Text score;
    public Text highScore;

    // Start is called before the first frame update
    void Start()
    {
        /*score = GetComponent<Text>();
        highScore.text = "High Score: "+ PlayerPrefs.GetInt("HighScore", 0).ToString();*/
    }

    // Update is called once per frame
    void Update()
    {
       /*core.text = "Score: "+ Score.scoreValue + " pts";
        if(Score.scoreValue > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", Score.scoreValue);
            highScore.text = "High Score: " + Score.scoreValue.ToString();
        }*/
    }
}
