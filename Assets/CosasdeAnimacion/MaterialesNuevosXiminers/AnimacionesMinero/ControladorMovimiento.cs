using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorMovimiento : MonoBehaviour
{

    Animator anim;
    private SpriteRenderer mySpriteRenderer;
    public float speed = 0.2f;
    Vector3 movimiento;
    Vector3 rot = Vector3.zero;
    public static int tipoPico;

    private void Awake()
    {
        mySpriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        tipoPico = 1;

    }

    // Update is called once per frame
    void Update()
    {
        if(Detector.move)
        {
            if(Input.GetKeyDown(KeyCode.A) ||Input.GetKeyDown(KeyCode.LeftArrow))
            {
                if (mySpriteRenderer != null)
                {
                    mySpriteRenderer.flipX = true;
                }
            }
            if(Input.GetKeyDown(KeyCode.D)||Input.GetKeyDown(KeyCode.RightArrow))
            {
                if(mySpriteRenderer!=null)
                {
                    mySpriteRenderer.flipX = false;
                   
                }
            }
            //anim.SetInteger("mineroCambiarPico", 1);
            cambiarAnimacion(tipoPico);
            anim.SetFloat("animationSpeed", 2);
           // gameObject.transform.position = new Vector3(gameObject.transform.position.x + speed * Input.GetAxis("Horizontal"), gameObject.transform.position.y + speed * Input.GetAxis("Vertical"), gameObject.transform.position.z);

        }
        else
        {
            cambiarAnimacion(0);
        }
    }

    public void cambiarAnimacion(int animacion)
    {
        if(animacion == 1)
        {
            anim.SetBool("animacionPicoPiedra", true);
        }
        if(animacion == 2)
        {
            anim.SetBool("animacionPicoBronze", true);
        }
        if(animacion == 3)
        {
            anim.SetBool("animacionPicoPlata", true);
        }
        if(animacion == 4)
        {
            anim.SetBool("animacionPicoOro", true);
        }
        if(animacion == 5)
        {
            anim.SetBool("animacionPicoDiamante", true);

        }
        if(animacion == 0)
        {
            anim.SetBool("animacionPicoPiedra", false);
            anim.SetBool("animacionPicoOro", false);
            anim.SetBool("animacionPicoDiamante", false);
            anim.SetBool("animacionPicoBronze", false);
            anim.SetBool("animacionPicoPlata", false);
        }
    }
}
