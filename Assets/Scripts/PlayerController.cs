using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Animator thisAnim;
    private Rigidbody2D rigid;
    public float groundDistance = 0.3f;
    public LayerMask whatiIsGround;

    // Start is called before the first frame update
     void Start()
    {
        thisAnim = GetComponent<Animator>();
        rigid = GetComponent<Rigidbody2D>();
    }
 
    // Update is called once per frame
    void Update()
    {
        var h = Input.GetAxis("Horizontal");
 
        thisAnim.SetFloat("Speed", Mathf.Abs(h));
 
        if (h < 0.0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        else if (h > 0.0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
 
    }
}
