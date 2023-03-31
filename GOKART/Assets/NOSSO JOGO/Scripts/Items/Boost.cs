using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KartGame.KartSystems;
using UnityEngine.Events;

public class Boost : MonoBehaviour, IUsable
{
    public ArcadeKart.StatPowerup boostStats = new ArcadeKart.StatPowerup
    {
        MaxTime = 5
    };
    public float boostDuration, amountToBoost;
    public UnityEvent onPowerupActivated;
    public UnityEvent onPowerupFinishCooldown;

    public void Use(ArcadeKart kart)
    {
        //kart.boostPower = amountToBoost;
        //kart.boostTime = boostDuration;
        //kart.m_FinalStats.Acceleration = amountToBoost;
        //StartCoroutine(PowerCountDown(kart));
        AtivarBoost(kart);
        print("HasUsedItem");
        print(kart.currentSpeed);
    }


    //IEnumerator PowerCountDown(ArcadeKart kart)
    //{
    //    yield return new WaitForSeconds(boostDuration);
    //    kart.boostPower -= amountToBoost ;
    //    kart.m_FinalStats.Acceleration -= amountToBoost;

    //}

    void AtivarBoost(ArcadeKart kart)
    {
        
        kart.AddPowerup(this.boostStats);
        onPowerupActivated.Invoke();
        onPowerupFinishCooldown.Invoke();
       if(boostStats.ElapsedTime != 0)
        {
            boostStats.ElapsedTime = 0;
        }
    }

}
