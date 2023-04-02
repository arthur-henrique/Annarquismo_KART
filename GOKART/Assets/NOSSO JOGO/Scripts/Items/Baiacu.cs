using KartGame.KartSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Baiacu : MonoBehaviour, IUsable
{

    public GameObject baiacu;
    public ItemCollider item;


    public void Use(ArcadeKart kart )
    {
        ColocarBaiacu();
        item.imagemItem.SetActive(false);
        
    }

    void ColocarBaiacu()
    {
       
        Instantiate(baiacu, item.baiacuSpawn.position, item.baiacuSpawn.rotation);
    }
   

}
