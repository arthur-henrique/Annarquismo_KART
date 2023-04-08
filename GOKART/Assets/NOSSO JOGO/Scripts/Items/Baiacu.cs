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
        GameObject sprtiteItem = ItemHandler.InstanceItemHandler.slots[item.i].transform.GetChild(item.randomNumber).gameObject;
        sprtiteItem.SetActive(false);
        ItemHandler.InstanceItemHandler.isFull[item.i] = false;
    }
   

}
