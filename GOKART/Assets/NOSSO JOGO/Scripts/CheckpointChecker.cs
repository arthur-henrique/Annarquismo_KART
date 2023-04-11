using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KartGame.KartSystems;


public class CheckpointChecker : MonoBehaviour
{
    private Rigidbody rb;
    public ArcadeKart kart;

    private void OnTriggerEnter(Collider other)
    {
        rb = other.attachedRigidbody;

        if (other.CompareTag("Player"))
        {
            kart = rb.GetComponent<ArcadeKart>();
            kart.SetSpawn(transform.position, transform.rotation);
            print("Checkpoint");
        }
    }
}
