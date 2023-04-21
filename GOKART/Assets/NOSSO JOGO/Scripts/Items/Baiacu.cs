using KartGame.KartSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Baiacu : MonoBehaviour, IUsable
{
    
    public GameObject baiacu;
    public ItemCollider item;

   

    public void Use(ArcadeKart kart )
    {
        ColocarBaiacu();
        
        
    }

    void ColocarBaiacu()
    {

        item.baiacuSpawn.SetActive(true);
        item.itemHandler.isFull = false;
       
    }
   

}
