using KartGame.KartSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TubaraoColl : MonoBehaviour
{
    public ArcadeKart userKart;
    private ArcadeKart otherPeopleKart;
    private Rigidbody rb;

    public float slowDuration;

    public ArcadeKart.StatPowerup boostStats = new ArcadeKart.StatPowerup
    {
        MaxTime = 5
    };
    public UnityEvent onPowerupActivated;

    private void OnTriggerEnter(Collider other)
    {
        rb = other.attachedRigidbody;
        if(other.CompareTag("Player"))
        {
            var kart = rb.GetComponent<ArcadeKart>();
            if (kart && kart != userKart)
            {
                print("ISlowedDown");
                kart.AddPowerup(this.boostStats);
                onPowerupActivated.Invoke();
                boostStats.MaxTime += slowDuration;
            }
        }
        
        else if (other.CompareTag("Obstaculos"))
        {
            Destroy(other.gameObject);
        }

    }
}
