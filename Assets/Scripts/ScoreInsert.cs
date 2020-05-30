using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class ScoreInsert : MonoBehaviour
{
    public string InputMiner, InputScore;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AddMiner(string miner, int score)
    {
        WWWForm form = new WWWForm();
        form.AddField("addMiner", miner);
        form.AddField("addScore", score);

        WWW www = new WWW("http://the-art-of-software-design.net/phpMyAdmin/scoreSelect.php", form);
    }
}
