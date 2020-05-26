using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System; //para el event

public class Inventory
{
    public static int bronze = 0;
    public static int silver = 0;
    public static int gold = 0;
    public static int diamond = 0;

    public event EventHandler OnItemListChanged; //actualizar el inventario

    private List<Item> itemList;

    public Inventory()
    {
        itemList = new List<Item>();

        //testing 
      
        AddItem(new Item { itemType = Item.ItemType.Cobre, amount = 1 });
        AddItem(new Item { itemType = Item.ItemType.Plata, amount = 1 });
        AddItem(new Item { itemType = Item.ItemType.Oro, amount = 1 });
        AddItem(new Item { itemType = Item.ItemType.Diamante, amount = 1 });

  
        Debug.Log(itemList.Count);
    }

    public void AddItem(Item item)
    {
        if (item.IsStackable()) //*en realidad todo son acumulables , solo es para tener la opcion 
        {
            bool itemAlredayInInventory = false;
            //Si ya existe solo se le suma una más
            foreach(Item inventoryItem in itemList)
            {
                if(inventoryItem.itemType == item.itemType)
                {
                    inventoryItem.amount += item.amount;
                    itemAlredayInInventory = true;
                }
            }
            if (!itemAlredayInInventory)
            {
                itemList.Add(item);
            }
        }
        else
        {
            itemList.Add(item);
        }
       
        OnItemListChanged?.Invoke(this,EventArgs.Empty);
    }
    public List<Item> GetItemList()
    {
        return itemList;
    }
}
