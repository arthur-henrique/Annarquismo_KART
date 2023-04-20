using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KartGame.KartSystems;
using UnityEngine.Events;

public class Boost : MonoBehaviour, IUsable
{
    public ItemCollider item;
    public ArcadeKart.StatPowerup boostStats = new ArcadeKart.StatPowerup
    {
        MaxTime = 5
    };
    public float boostDuration, amountToBoost;
    public UnityEvent onPowerupActivated;
    public UnityEvent onPowerupFinishCooldown;
  

    public void Use(ArcadeKart kart)
    {
    
        AtivarBoost(kart);
      
        
    }


    void AtivarBoost(ArcadeKart kart)
    {
        
        kart.AddPowerup(this.boostStats);
        onPowerupActivated.Invoke();
        onPowerupFinishCooldown.Invoke();
       if(boostStats.ElapsedTime != 0)
        {
            boostStats.ElapsedTime = 0;
        }
        GameObject sprtiteItem = item.itemHandler.slots.transform.GetChild(1).gameObject;
        sprtiteItem.SetActive(false);
        item.itemHandler.isFull = false;
    }

}
