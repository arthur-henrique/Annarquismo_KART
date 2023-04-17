using KartGame.KartSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CrabGrudar : MonoBehaviour
{
    public float slowDuration;
    private Rigidbody rb;
    
    public ArcadeKart.StatPowerup boostStats = new ArcadeKart.StatPowerup
    {
        MaxTime = 5
    };
    public UnityEvent onPowerupActivated;
    private void Start()
    {
        StartCoroutine(KillTheCrab());   
    }
    private void OnTriggerEnter(Collider other)
    {
        rb = other.attachedRigidbody;

        if (other.CompareTag("Player"))
        {

            var kart = rb.GetComponent<ArcadeKart>();
            //var kart = rb.GetComponent<Rigidbody>();


            if (kart && kart.canBeEffected)
            {
                kart.AddPowerup(this.boostStats);
                onPowerupActivated.Invoke();
                boostStats.MaxTime = boostStats.MaxTime + slowDuration;
                gameObject.SetActive(false);

            }
        }
        else if (other.CompareTag("Obstaculos"))
        {
            Destroy(other.gameObject);
            gameObject.SetActive(false);
        }
    }
    IEnumerator KillTheCrab()
    {
        yield return new WaitForSeconds(5f);
        gameObject.SetActive(false);
       
    }




}
