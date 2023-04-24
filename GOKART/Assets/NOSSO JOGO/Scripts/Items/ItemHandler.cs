using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KartGame.KartSystems;

public class ItemHandler : MonoBehaviour
{
    public static ItemHandler InstanceItemHandler;
    public bool _hasItem;
    public GameObject item;
    public bool isFull;
    public GameObject slots;
    public ArcadeKart kart;
    public ItemCollider itemCollider;
    public bool isPlayer1, isPlayer2;


    private void Awake()
    {
        InstanceItemHandler = this;
    }





    public void HasItem(bool hasItem, GameObject itemToGet)
    {
        _hasItem = hasItem;
        item = itemToGet;
    }

    private void Update()
    {
        if (_hasItem && item != null)
            if (Input.GetKeyDown(KeyCode.LeftShift) && isPlayer1)
        {
           
            
                _hasItem = false;
                if (item.TryGetComponent(out IUsable usableItem))
                {
                    usableItem.Use(kart);
                   

                }
                
            
        }
             if (_hasItem && item != null)
            if (Input.GetKeyDown(KeyCode.RightShift) && isPlayer2)
        {
           
            {
                _hasItem = false;
                if (item.TryGetComponent(out IUsable usableItem))
                {
                    usableItem.Use(kart);


                }

            }
        }
       
                    

    }
    
}
