using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KartGame.KartSystems;

public class Boost : MonoBehaviour, IUsable
{
    public float boostDuration, amountToBoost;

    public void Use(ArcadeKart kart)
    {
        kart.boostPower = amountToBoost;
        kart.boostTime = boostDuration;
        kart.m_FinalStats.Acceleration = amountToBoost;
        StartCoroutine(PowerCountDown(kart));
        print("HasUsedItem");
        print(kart.currentSpeed);
    }

    IEnumerator PowerCountDown(ArcadeKart kart)
    {
        yield return new WaitForSeconds(boostDuration);
        kart.boostPower -= amountToBoost ;
        kart.m_FinalStats.Acceleration -= amountToBoost;

    }
}
