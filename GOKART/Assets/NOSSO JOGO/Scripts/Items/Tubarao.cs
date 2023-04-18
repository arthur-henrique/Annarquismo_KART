using KartGame.KartSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using UnityEngine.Events;

public class Tubarao : MonoBehaviour, IUsable
{
    public GameObject[] tubaObj;
    //public CinemachineVirtualCamera defaultCam, tubaCam;
    public ArcadeKart userKart;
    public ItemCollider itemCollider;

    public ArcadeKart.StatPowerup boostStats = new ArcadeKart.StatPowerup
    {
        MaxTime = 5
    };
    public UnityEvent onPowerupActivated;
    public UnityEvent onPowerupFinishCooldown;

    public void Start()
    {
        
    }

    public void Use(ArcadeKart kart)
    {
        itemCollider.tuba.SetActive(true);
        AtivarBoost(kart);
        itemCollider.defaultCam.Priority = 0;
        itemCollider.tubaCam.Priority = 10;
        userKart = kart;
        StartCoroutine(Destubarar());
    }

    IEnumerator Destubarar()
    {
        yield return new WaitForSecondsRealtime(5f);
        itemCollider.tuba.SetActive(false);
        itemCollider.defaultCam.Priority = 10;
        itemCollider.tubaCam.Priority = 0;
    }

    void AtivarBoost(ArcadeKart kart)
    {

        kart.AddPowerup(this.boostStats);
        onPowerupActivated.Invoke();
        onPowerupFinishCooldown.Invoke();
        if (boostStats.ElapsedTime != 0)
        {
            boostStats.ElapsedTime = 0;
        }
        //GameObject sprtiteItem = ItemHandler.InstanceItemHandler.slots[item.i].transform.GetChild(item.randomNumber).gameObject;
        //sprtiteItem.SetActive(false);
        //ItemHandler.InstanceItemHandler.isFull[item.i] = false;
    }
}
