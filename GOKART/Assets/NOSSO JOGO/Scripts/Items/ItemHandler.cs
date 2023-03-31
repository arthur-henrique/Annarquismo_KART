using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KartGame.KartSystems;

public class ItemHandler : MonoBehaviour
{
    public bool _hasItem;
    public GameObject item;
    public ArcadeKart kart;

    public void HasItem(bool hasItem, GameObject itemToGet)
    {
        _hasItem = hasItem;
        item = itemToGet;
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            if(_hasItem && item != null)
            {
                _hasItem = false;
                if(item.TryGetComponent(out IUsable usableItem))
                {
                    usableItem.Use(kart);
                }
            }
        }
        else
            print(kart.m_FinalStats.TopSpeed);

    }
    
}
