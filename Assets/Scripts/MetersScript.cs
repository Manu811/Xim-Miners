using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MetersScript : MonoBehaviour
{
    public static int metersValue = 0;

    Text meters;

    // Start is called before the first frame update
    void Start()
    {
        meters = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        meters.text = metersValue + " mts";
    }
}
