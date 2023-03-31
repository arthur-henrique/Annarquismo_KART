using KartGame.KartSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carangueijo : MonoBehaviour, IUsable
{
    public Transform firePoint;
    public GameObject crab;

    public void Use(ArcadeKart kart)
    {
        SpawnarCrab();
    }
    void SpawnarCrab()
    {
        crab.SetActive(true);
    }
}
