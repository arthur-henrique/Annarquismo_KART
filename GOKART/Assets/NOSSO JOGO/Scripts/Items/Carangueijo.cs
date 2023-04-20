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
        StartCoroutine(CrabGrudar.instanceCrab.KillTheCrab());


    }
    void SpawnarCrab()
    {
        item.crab.SetActive(true);
        GameObject sprtiteItem = item.itemHandler.slots.transform.GetChild(2).gameObject;
        sprtiteItem.SetActive(false);
        item.itemHandler.isFull = false;
        
    }
}
