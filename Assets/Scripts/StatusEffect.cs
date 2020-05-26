using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusEffect : MonoBehaviour
{
    public Lives canvas_lives;
    public static int vida = 3;
    public int waterTime = 500;
    public bool onWater;
    public static bool move;
    private int cont;

    // Start is called before the first frame update
    void Start()
    {
        canvas_lives = GameObject.FindObjectOfType<Lives>();
        cont = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Water: "+onWater+" Move: "+move);

        canvas_lives.cambioVida(vida);
        if (onWater)
        {
            cont++;
            if(vida != 0 && cont == waterTime)
            {
                vida--;
                cont = 0;
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
        if(vida == 0)
        {
            Time.timeScale = 0;
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Water"))
        {
            onWater = true;
        }
    }
}
