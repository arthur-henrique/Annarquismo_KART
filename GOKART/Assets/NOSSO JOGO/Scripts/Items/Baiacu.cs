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
       
        Instantiate(baiacu, item.baiacuSpawn.position, item.baiacuSpawn.rotation);
        GameObject sprtiteItem =item.itemHandler.slots.transform.GetChild(0).gameObject;
        sprtiteItem.SetActive(false);
        item.itemHandler.isFull = false;
    }
   

}
