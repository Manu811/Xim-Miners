using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeaderScript : MonoBehaviour
{
    Canvas canvas;
    public static bool leader = false;

    // Start is called before the first frame update
    void Start()
    {
        canvas = GetComponent<Canvas>();
        canvas.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        if(leader == true)
        {
            canvas.enabled = true;
        }

    }
    public void exitScore()
    {
        canvas.enabled = false;
        Death.tacaño = true;
        leader = false;
    }
}
