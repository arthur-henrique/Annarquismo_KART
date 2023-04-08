using KartGame.KartSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carangueijo : MonoBehaviour, IUsable
{
    public ItemCollider item;

    public void Use(ArcadeKart kart)
    {
        SpawnarCrab();
       
    }
    void SpawnarCrab()
    {
        item.crab.SetActive(true);
        GameObject sprtiteItem = ItemHandler.InstanceItemHandler.slots[item.i].transform.GetChild(item.randomNumber).gameObject;
        sprtiteItem.SetActive(false);
        ItemHandler.InstanceItemHandler.isFull[item.i] = false;
    }
}
