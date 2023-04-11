using KartGame.KartSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FallCatch : MonoBehaviour
{
    private Rigidbody rb;
    float tempoDeStun;
    [SerializeField] float maxTempStun;
    bool stunado, stunadoOver;

    public ArcadeKart kart;

    public ArcadeKart.StatPowerup boostStats = new ArcadeKart.StatPowerup
    {
        MaxTime = 5
    };
    public UnityEvent onPowerupActivated;
    private void Update()
    {
        if (stunado)
        {
            rb.constraints = RigidbodyConstraints.FreezePositionX;
            rb.constraints = RigidbodyConstraints.FreezePositionZ;
        }
    }


    private void OnTriggerEnter(Collider other)
    {


        rb = other.attachedRigidbody;

        if (rb)
        {

            kart = rb.GetComponent<ArcadeKart>();
            //var kart = rb.GetComponent<Rigidbody>();


            if (kart)
            {
                stunado = true;
                EventToCall();
            }
        }
    }

    public void EventToCall()
    {
        StartCoroutine(TimeOver());
    }
    IEnumerator TimeOver()
    {
        yield return new WaitForSeconds(maxTempStun);
        kart.ReSpawn();
        stunado = false;
        rb.constraints = RigidbodyConstraints.None;

    }

}
