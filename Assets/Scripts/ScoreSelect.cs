using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class ScoreSelect : MonoBehaviour
{
    public string[] usersData;
    public static string firstPos;
    public static string secondPos;
    public static string thirdPos;
    public static string fourthPos;
    public static string fifthPos;

    public static string firstScore;
    public static string secondScore;
    public static string thirdScore;
    public static string fourthScore;
    public static string fifthScore;

    void Start()
    {
        StartCoroutine(GetText());
    }
    IEnumerator GetText() { 

        UnityWebRequest miner = new UnityWebRequest("http://the-art-of-software-design.net/phpMyAdmin/scoreSelect.php");
        miner.downloadHandler = new DownloadHandlerBuffer();
        yield return miner.SendWebRequest();


        if (miner.isNetworkError || miner.isHttpError)
        {
            Debug.Log(miner.error);
        }
        else
        {
            Debug.Log("Coneccion establecida");
            string usersDataString = miner.downloadHandler.text;
            
            usersData = usersDataString.Split(';');

            firstPos = getValueData(usersData[0], "miner: ");
            secondPos = getValueData(usersData[1], "miner: ");
            thirdPos = getValueData(usersData[2], "miner: ");
            fourthPos = getValueData(usersData[3], "miner: ");
            fifthPos = getValueData(usersData[4], "miner: ");

            firstScore = getValueData(usersData[0], "score:");
            secondScore = getValueData(usersData[1], "score:");
            thirdScore = getValueData(usersData[2], "score:");
            fourthScore = getValueData(usersData[3], "score:");
            fifthScore = getValueData(usersData[4], "score:");
        }
        
    }

    string getValueData(string data, string index)
    {
        string value = data.Substring(data.IndexOf(index) + index.Length);
        if (value.Contains("&"))
        {
            value = value.Remove(value.IndexOf("&"));
        }
        return value;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
