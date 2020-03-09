using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour{
    Rigidbody2D player;
    float movementx, movementy;
    public float speed;
    public int lifes;

    // Start is called before the first frame update
    void Start(){
        player = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update(){
        movementx = Input.GetAxis("Horizontal")*speed;
        player.MovePosition(new Vector2(player.position.x + movementx, player.position.y));

    }

    private void OnCollisionEnter2D(Collision2D collision){
        movementy = Input.GetAxis("Vertical");
        if (movementy < 0){
            if (collision.transform.CompareTag("Dirt")){
                Destroy(collision.gameObject);
            }
        }
        
    }
}
