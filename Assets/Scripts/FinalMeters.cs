using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalMeters : MonoBehaviour
{

    Text mts;
    // Start is called before the first frame update
    void Start()
    {
        mts = GetComponent<Text>();
    }

    void Update()
    {
        mts.text = "Meters: "+ MetersScript.metersValue + " mts";
    }
}
