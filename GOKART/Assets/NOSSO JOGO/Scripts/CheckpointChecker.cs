using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KartGame.KartSystems;


public class CheckpointChecker : MonoBehaviour
{
    private Rigidbody rb;
    public ArcadeKart kart;
    public PassarVoltas passarVoltas;
    public bool inCooldown1, inCooldown2;


    private void Update()
    {
        if(passarVoltas.pegouCheckpoint == passarVoltas.numCheckpoint)
        {
            passarVoltas.completou = true;
            passarVoltas.pegouCheckpoint = 0;
        }
        if (passarVoltas.pegouCheckpoint2 == passarVoltas.numCheckpoint)
        {
            passarVoltas.completou2 = true;
            passarVoltas.pegouCheckpoint2 = 0;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        rb = other.attachedRigidbody;
        var checkarPlayer = other.GetComponent<ItemHandler>();
        if(!inCooldown1)
        if (checkarPlayer.isPlayer1)
        {
            if (other.CompareTag("Player"))
            {
                 kart = rb.GetComponent<ArcadeKart>();
                kart.SetSpawn(transform.position, transform.rotation);
                print("Checkpoint");
                passarVoltas.pegouCheckpoint++;
                StartCoroutine(PodeColidirDnv());
                inCooldown1 = true;
            }


        } 
        if (!inCooldown2)
        if (checkarPlayer.isPlayer2)
        {

            kart = rb.GetComponent<ArcadeKart>();
            kart.SetSpawn(transform.position, transform.rotation);
            print("Checkpoint");
            passarVoltas.pegouCheckpoint2++;
                StartCoroutine(PodeColidirDnv2());
                inCooldown2 = true;
            }
    }
    IEnumerator PodeColidirDnv()
    {
        yield return new WaitForSeconds(10f);
        inCooldown1 = false;
        
    }
    IEnumerator PodeColidirDnv2()
    {
        yield return new WaitForSeconds(10f);
        inCooldown2 = false;

    }


}
