using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lives : MonoBehaviour
{
    public Sprite[] corazones;
    // Start is called before the first frame update
    void Start()
    {
        cambioVida(3);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void cambioVida(int pos)
    {
        this.GetComponent<Image>().sprite = corazones[pos];
    }
}
