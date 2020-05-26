using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoldScript : MonoBehaviour
{
    public static int material = 0;

    Text materialText;

    // Start is called before the first frame update
    void Start()
    {
        materialText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        materialText.text = material + "";
    }
}
