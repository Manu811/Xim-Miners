using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour

   
{
    //Mandar a llamar , poner el script
    [SerializeField] private UI_Inventory uiInventory;
    private Inventory inventory;
    // Start is called before the first frame update
    void Awake()
    {
        inventory = new Inventory();
        uiInventory.SetInventory(inventory); //invetory objetc to an inventary script
     
        Debug.Log("creados");
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        ItemWorld itemWorld = collider.GetComponent<ItemWorld>();
        if(itemWorld != null)
        {
            //Touchig item 
            inventory.AddItem(itemWorld.GetItem());
            itemWorld.DestroySelf();

        }
        
    }

  
}
