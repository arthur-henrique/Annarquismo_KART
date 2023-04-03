using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static InventarioItem;

public class Inventario : MonoBehaviour
{
    private const int slots = 2;
    private List<IInventoryItem> mItens = new List<IInventoryItem>();
    public event EventHandler<InventoryEventsArgs> itemAdded;
    
    public void AddItem(IInventoryItem item)
    {
        if (mItens.Count < slots)
        {
            Collider collider = (item as MonoBehaviour).GetComponent<Collider>();
            if (collider.enabled)
            {
                collider.enabled = false;
                mItens.Add(item);
                item.OnPickup();
            }
            if(itemAdded != null)
            {
                itemAdded(this, new InventoryEventsArgs(item));
            }
        }
    }

}
