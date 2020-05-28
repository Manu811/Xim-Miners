using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEditor;

public class Detector : MonoBehaviour
{
    public Lives canvas_lives;
    public static int vida = 3;
    public static bool move;
    public static bool death;
    public static bool pause;
    public bool goDown;
    public bool goLeft;
    public bool goRight;
    public GameObject floor;
    public GameObject character;
    private GameObject block;
    private BoxCollider2D coll;

    public int speed;
    private int coolDown;

    public GameObject emisorSonido;
    public bool playSound;
    private AudioSource source;

    private SpriteRenderer spriteRenderer;
    public Sprite newSprite;

    public bool plata, oro, diamante;
    
    void ChangeSprite()
    {
        spriteRenderer.sprite = newSprite;
    }

    // Start is called before the first frame update
    void Start()
    {
        plata = false;
        oro = false;
        diamante = false;
        speed = 70;
        canvas_lives = GameObject.FindObjectOfType<Lives>();
        death = false;
        coll = gameObject.GetComponent<BoxCollider2D>();
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        coolDown = 0;
        source = emisorSonido.GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        SendMessage("sonidoMuerteXime", false);
        canvas_lives.cambioVida(vida);
        if (!death && !pause)
        {
            move = false;
            WaterEffect.move = false;
            goDown = Input.GetKey(KeyCode.DownArrow);
            goLeft = Input.GetKey(KeyCode.LeftArrow);
            goRight = Input.GetKey(KeyCode.RightArrow);
            if (coolDown >= speed)
            {
                if (goDown)
                {
                    Sound();
                    coolDown = 0;
                    move = true;
                    WaterEffect.move = true;
                    coll.offset = new Vector2(0, -1.1f);
                    character.transform.position = new Vector3(character.transform.position.x, character.transform.position.y - (float)4.5);
                    floor.transform.position = new Vector3(floor.transform.position.x, floor.transform.position.y - (float)4.5);
                    coll.offset = new Vector2(0, 0);

                    Score.scoreValue = Score.scoreValue + 2;
                    MetersScript.metersValue = MetersScript.metersValue + 2;

                }
                if (goLeft)
                {
                    coolDown = 0;
                    move = true;
                    WaterEffect.move = true;
                    coll.offset = new Vector2(-4, 0);
                    character.transform.position = new Vector3(character.transform.position.x - (float)4.5, character.transform.position.y);
                    coll.offset = new Vector2(0, 0);


                }
                if (goRight)
                {
                    coolDown = 0;
                    move = true;
                    WaterEffect.move = true;
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
        if (collision.gameObject.tag.Equals("Bronze"))
        {
            block = collision.gameObject;
            spriteRenderer = block.GetComponent<SpriteRenderer>();
            ChangeSprite();
            Destroy(block);
            source.Play();

            if (BronzeScript.material < 4)
            {
                BronzeScript.material = BronzeScript.material + 1;
                if(BronzeScript.material == 4 && !plata && !oro && !diamante)
                {
                    speed = 60;
                    ControladorMovimiento.tipoPico = 2;
                }
            }
            else
            {
                Score.scoreValue += 5;
            }
        }
        if (collision.gameObject.tag.Equals("Silver"))
        {
            block = collision.gameObject;
            spriteRenderer = block.GetComponent<SpriteRenderer>();
            ChangeSprite();
            Destroy(block);
            source.Play();
            if (silverScript.material < 6)
            {
                silverScript.material = silverScript.material + 1;
                if (silverScript.material == 6 && !oro && !diamante)
                {
                    plata = true;
                    speed = 50;
                    ControladorMovimiento.tipoPico = 3;
                }
            }
            else
            {
                Score.scoreValue += 10;
            }
        }
        if (collision.gameObject.tag.Equals("Gold"))
        {
            block = collision.gameObject;
            spriteRenderer = block.GetComponent<SpriteRenderer>();
            ChangeSprite();
            Destroy(block);
            source.Play();

            if (GoldScript.material < 8)
            {
                GoldScript.material = GoldScript.material + 1;
                if (GoldScript.material == 8 && !diamante)
                {
                    plata = false;
                    oro = true;
                    speed = 30;
                    ControladorMovimiento.tipoPico = 4;
                }
            }
            else
            {
                Score.scoreValue += 30;
            }
        }
        if (collision.gameObject.tag.Equals("Diamond"))
        {
            block = collision.gameObject;
            spriteRenderer = block.GetComponent<SpriteRenderer>();
            ChangeSprite();
            
            source.Play();
            if(DiamondScript.material < 10)
            {
                DiamondScript.material = DiamondScript.material + 1;
                if (DiamondScript.material == 10)
                {
                    plata = false;
                    oro = false;
                    diamante = true;
                    speed = 15;
                    ControladorMovimiento.tipoPico = 5;
                }
            }
            else
            {
                Score.scoreValue += 50;
            }
        }
        
        if (collision.gameObject.tag.Equals("silverGem"))
        {
            block = collision.gameObject;
            Destroy(block);
            Score.scoreValue += 10;
        }
        if (collision.gameObject.tag.Equals("goldGem"))
        {
            block = collision.gameObject;
            Destroy(block);
            Score.scoreValue += 30;
        }
        if (collision.gameObject.tag.Equals("diamondGem"))
        {
            block = collision.gameObject;
            Destroy(block);
            Score.scoreValue += 50;
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