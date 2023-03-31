using KartGame.KartSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Baiacu : MonoBehaviour, IUsable
{
    public Transform firePoint;
    public GameObject baiacu;


    public void Use(ArcadeKart kart)
    {
        ColocarBaiacu();
        
    }

    void ColocarBaiacu()
    {
        Instantiate(baiacu, firePoint.position, firePoint.rotation);
    }

}
