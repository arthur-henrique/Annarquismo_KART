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
        item.imagemItem.SetActive(false);
    }
    void SpawnarCrab()
    {
        item.crab.SetActive(true);
    }
}
