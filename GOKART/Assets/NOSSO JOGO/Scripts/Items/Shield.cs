using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KartGame.KartSystems;


public class Shield : MonoBehaviour, IUsable
{
    ArcadeKart userKart;
    public GameObject shieldCollider;
    // Reference to the VFX component / game object goes here

    public void Use(ArcadeKart kart)
    {
        userKart = kart;
        userKart.canBeEffected = false;
        shieldCollider.SetActive(true);
        // either activate or enable the VFX Component
        StartCoroutine(ShieldWearOff());
        
    }

    public void ShieldIsDown()
    {
        userKart.canBeEffected = true;
        shieldCollider.SetActive(false);
        // either deactivate or disable the VFX Component
    }

    IEnumerator ShieldWearOff()
    {
        yield return new WaitForSecondsRealtime(5f);
        ShieldIsDown();
    }
}
