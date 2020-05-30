using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Boss : MonoBehaviour
{
    public Sprite[] images;
    private int cont;

    // Start is called before the first frame update
    void Start()
    {
        cont = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (!Detector.move && Detector.vida != 0 && !Detector.pause)
        {
            cont++;
            if(cont == 2750)
            {
                //ChangeSprite1();
                cambioMessage(1);
            }
            if(cont == 4000)
            {
                cambioMessage(2);
                //ChangeSprite2();
                Detector.death = true;
                
            }
            if (cont == 4500)
            {
                Detector.vida = 0;
            }
        }
        else
        {
            cont = 0;
            cambioMessage(0);
            //ChangeSprite3();
        }
        
    }

    public void cambioMessage(int pos)
    {
        this.GetComponent<Image>().sprite = images[pos];
    }
}
