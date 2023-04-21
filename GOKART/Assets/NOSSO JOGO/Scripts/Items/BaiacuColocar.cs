using KartGame.KartSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaiacuColocar : MonoBehaviour, IUsable
{
    public GameObject baiacu;
    public ItemHandler item;
    public Transform firepoint;
   
    private void FixedUpdate()
    {
        item.HasItem(true, gameObject);
    }
    public void Use(ArcadeKart kart)
    {
        ColocarBaiacu();
    }

    void ColocarBaiacu()
    {
        
        gameObject.SetActive(false);
        GameObject sprtiteItem =ItemCollider.instanceCollider.itemHandler.slots.transform.GetChild(0).gameObject;
        sprtiteItem.SetActive(false);
        Instantiate(baiacu, firepoint.position , firepoint.rotation);
    }
    

}
