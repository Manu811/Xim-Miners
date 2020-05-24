using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEditor;

public class Detector : MonoBehaviour
{
    public bool goDown;
    public bool goLeft;
    public bool goRight;
    public GameObject floor;
    public GameObject character;
    public GameObject leftWall;
    public GameObject rightWall;
    private GameObject block;
    private BoxCollider2D coll;

    public int speed = 50;
    private int coolDown;

    private int score;

    public GameObject emisorSonido;
    public bool playSound;
    private AudioSource source;

    private SpriteRenderer spriteRenderer;
    public Sprite newSprite;

    public Lives canvas_lives;
    public int vida = 3;

    void ChangeSprite()
    {
        spriteRenderer.sprite = newSprite;
    }

    // Start is called before the first frame update
    void Start()
    {
        canvas_lives = GameObject.FindObjectOfType<Lives>();
        coll = gameObject.GetComponent<BoxCollider2D>();
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        coolDown = 0;
        source = emisorSonido.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        canvas_lives.cambioVida(vida);
        goDown = Input.GetKey(KeyCode.DownArrow);
        goLeft = Input.GetKey(KeyCode.LeftArrow);
        goRight = Input.GetKey(KeyCode.RightArrow);
        if (coolDown >= speed)
        {
            if (goDown)
            {
                Sound();

                coolDown = 0;
                coll.offset = new Vector2(0, -1.1f);
                character.transform.position = new Vector3(character.transform.position.x, character.transform.position.y - (float)4.5);
                floor.transform.position = new Vector3(floor.transform.position.x, floor.transform.position.y - (float)4.5);
                coll.offset = new Vector2(0, 0);
                score++;
                Debug.Log("Score: " + score);

            }
            if (goLeft)
            {
                coolDown = 0;
                coll.offset = new Vector2(-4, 0);
                character.transform.position = new Vector3(character.transform.position.x - (float)4.5, character.transform.position.y);
                coll.offset = new Vector2(0, 0);

            }
            if (goRight)
            {

                coolDown = 0;
                coll.offset = new Vector2(4, 0);
                character.transform.position = new Vector3(character.transform.position.x + (float)4.5, character.transform.position.y);
                coll.offset = new Vector2(0, 0);
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
            spriteRenderer = block.GetComponent<SpriteRenderer>();
            ChangeSprite();
            Destroy(block);
            source.Play();
        }
    }

    private void Sound()
    {
        if (playSound && !source.isPlaying)
        {
            source.Play();
        }

    }

    public void Pausa()
    {
        Debug.Log("Apretaste Pausa");
        SceneManager.LoadScene("Pausa");
    }
}