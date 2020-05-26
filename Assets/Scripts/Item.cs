using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item 
{
   public enum ItemType
    {
      
        Cobre,
        Plata,
        Oro,
        Diamante,

    }
    public ItemType itemType;
    public int amount;

    public Sprite GetSprite()
    {
        switch (itemType)
        {
            default:
           
            case ItemType.Cobre: return ItemAssets.Instance.cobreSprite;
            case ItemType.Plata: return ItemAssets.Instance.plataSprite;
            case ItemType.Oro: return ItemAssets.Instance.oroSprite;
            case ItemType.Diamante: return ItemAssets.Instance.diamanteSprite;
        }
    }

    public bool IsStackable()
    {
        switch (itemType)
        {
            default:
            case ItemType.Cobre: return true;
            case ItemType.Plata: return true;
            case ItemType.Oro: return true;
            case ItemType.Diamante: return true;

        }
    }
}
