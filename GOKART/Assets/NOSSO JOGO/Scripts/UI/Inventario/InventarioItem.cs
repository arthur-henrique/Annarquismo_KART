using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventarioItem : MonoBehaviour
{
    public interface IInventoryItem
    {
        string name { get; }
        Sprite image { get; }
        void OnPickup();
    }
    public class InventoryEventsArgs : EventArgs
    {
        public InventoryEventsArgs(IInventoryItem itemUI)
        {
            ItemUI = itemUI;
        }
        public IInventoryItem ItemUI;

    }
}
