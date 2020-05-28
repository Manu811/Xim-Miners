
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemGenerator : MonoBehaviour
{
    public GameObject  goldGem, silverGem, diamondGem;
    public GameObject player;
    double offset = 4.5;
    double generatePosX;
    double generatePosY;
    public float spawnRate = 2f;

    float nextSpawn = 0f;

    int what;


    // Update is called once per frame
    void Update()
    {
        if(Time.time > nextSpawn)
        {
            what = Random.Range(1, 4);
            generatePosX = offset+(Random.Range(-3, 3))*offset;
            generatePosY = player.transform.position.y + Random.Range(-9, 0) * offset;

            switch (what){
                case 1:
                    Instantiate(goldGem, new Vector3((float)generatePosX, (float)generatePosY, 0), Quaternion.identity);
                    break;
                case 2:
                    Instantiate(silverGem, new Vector3((float)generatePosX, (float)generatePosY, 0), Quaternion.identity);
                    break;
                case 3:
                    Instantiate(diamondGem, new Vector3((float)generatePosX, (float)generatePosY, 0), Quaternion.identity);
                    break;
            }

            nextSpawn = Time.time + spawnRate;
        }
        
    }
}
