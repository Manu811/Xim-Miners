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

    private int coolDown;

    private int score;
    
    // Start is called before the first frame update
    void Start()
    {
        coll = gameObject.GetComponent<BoxCollider2D>();
        coolDown = 0;
    }

    // Update is called once per frame
    void Update()
    {
        goDown = Input.GetKey(KeyCode.DownArrow);
        goLeft = Input.GetKey(KeyCode.LeftArrow);
        goRight = Input.GetKey(KeyCode.RightArrow);
        if(coolDown >= 25)
        {
            if (goDown)
            {
                coolDown = 0;
                coll.offset = new Vector2(0, -1.1f);
                Destroy(block);
                character.transform.position = new Vector3(character.transform.position.x, character.transform.position.y - (float)4.5);
                floor.transform.position = new Vector3(floor.transform.position.x, floor.transform.position.y - (float)4.5);
                score++;
                Debug.Log("Score: " + score);
            }
            if (goLeft)
            {
                coolDown = 0;
                coll.offset = new Vector2(-4, 0);
                Destroy(block);
                character.transform.position = new Vector3(character.transform.position.x - (float)4.5, character.transform.position.y);

            }
            if (goRight)
            {
                coolDown = 0;
                coll.offset = new Vector2(4, 0);
                Destroy(block);
                character.transform.position = new Vector3(character.transform.position.x + (float)4.5, character.transform.position.y);
            }
            if (!goRight && !goLeft && !goDown)
            {
                coll.offset = new Vector2(0, 0);
            }
        }
        else
        {
            coolDown++;
            coll.offset = new Vector2(0, 0);
        }
        

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Block"))
        {
            block = collision.gameObject;
        }
        Debug.Log("Collision with: " + collision.gameObject.tag);
    }
}