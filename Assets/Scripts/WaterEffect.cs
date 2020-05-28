using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterEffect : MonoBehaviour
{
    public int waterTime;
    public bool onWater;
    public static bool move;
    private int cont;

    // Start is called before the first frame update
    void Start()
    {
        waterTime = 0;
        cont = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (onWater)
        {
            cont++;
            if (Detector.vida != 0 && cont == waterTime)
            {
                Detector.vida--;
                SendMessage("sonidoMuerteXime", true);
                cont = 0;
            }
            if (Detector.vida == 0)
            {
                ContinueScript.death = true;
            }
        }
        if (move)
        {
            onWater = false;
        }
        if (!onWater)
        {
            cont = 0;
        }
        if (Detector.vida == 0)
        {
            ContinueScript.death = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Water") || collision.gameObject.tag.Equals("Lava") || collision.gameObject.tag.Equals("Gas"))
        {
            onWater = true;
            if (collision.gameObject.tag.Equals("Water"))
            {
                waterTime = 50;
            }
            if (collision.gameObject.tag.Equals("Lava"))
            {
                waterTime = 30;
            }
            if (collision.gameObject.tag.Equals("Gas"))
            {
                waterTime = 15;
            }
        }
    }
}
