using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recharge : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Detector.death = false;
        ContinueScript.death = false;
        Time.timeScale = 1f;
        Detector.vida = 3;
        Score.scoreValue = 0;
        MetersScript.metersValue = 0;
        Death.tacaño = false;

        BronzeScript.material = 0;
        silverScript.material = 0;
        GoldScript.material = 0;
        DiamondScript.material = 0;
    }
    
}
