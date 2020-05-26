using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recharge : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
        StatusEffect.vida = 3;
        Score.scoreValue = 0;
        MetersScript.metersValue = 0;
        silverScript.material = 0;
        GoldScript.material = 0;
        BronzeScript.material = 0;
        DiamondScript.material = 0;
        
    }
    
}
