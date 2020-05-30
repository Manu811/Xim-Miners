using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FifthScore : MonoBehaviour
{
    Text first;

    // Start is called before the first frame update
    void Start()
    {
        first = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        first.text = "" + ScoreSelect.fifthScore;
    }
}

