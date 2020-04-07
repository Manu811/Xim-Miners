using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detector : MonoBehaviour
{
    public bool goDown;
    public bool goLeft;
    public bool goRight;
    public GameObject floor;
    public GameObject character;
    private GameObject block;
    private BoxCollider2D coll;

    
    // Start is called before the first frame update
    void Start()
    {
        coll = gameObject.GetComponent<BoxCollider2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        goDown = Input.GetKey(KeyCode.DownArrow);
        goLeft = Input.GetKey(KeyCode.LeftArrow);
        goRight = Input.GetKey(KeyCode.RightArrow);
        float f1 = 0.5f;
        float f2 = 0.5f;
        if (goDown)
        {
            coll.offset = new Vector2(0, -1.3f);
            Destroy(block);
            floor.transform.position = new Vector3(floor.transform.position.x, floor.transform.position.y - f1);
        }
        if (goLeft)
        {
            coll.offset = new Vector2(-5, 0);
            Destroy(block);
            character.transform.position = new Vector3(character.transform.position.x - f2, character.transform.position.y);
        }
        if (goRight)
        {
            coll.offset = new Vector2(5, 0);
            Destroy(block);
            character.transform.position = new Vector3(character.transform.position.x + f2, character.transform.position.y);
        }
        if (!goRight && !goLeft && !goDown)
        {
            coll.offset = new Vector2(0, 0);
            if (block != null)
                block.gameObject.GetComponent<SpriteRenderer>().color = Color.white;
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Block"))
        {
            if (block != null)
                block.gameObject.GetComponent<SpriteRenderer>().color = Color.white;
            block = collision.gameObject;
            block.gameObject.GetComponent<SpriteRenderer>().color = Color.yellow;
        }
        Debug.Log("Yeiiiiii :D choque contra: " + collision.gameObject.tag);
    }
}