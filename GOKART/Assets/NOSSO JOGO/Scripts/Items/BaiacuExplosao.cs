using KartGame.KartSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BaiacuExplosao : MonoBehaviour
{
    private Rigidbody rb;
    float tempoDeStun;
    [SerializeField] float maxTempStun;
    bool stunado, stunadoOver;
    public Animator anim;
   
    public ArcadeKart.StatPowerup boostStats = new ArcadeKart.StatPowerup
    {
        MaxTime = 5
    };
    public UnityEvent onPowerupActivated;
    private void Update()
    {
        if (stunado)
        {
            rb.constraints = RigidbodyConstraints.FreezeAll;           
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if(!other.CompareTag("Shark"))
        {
            rb = other.attachedRigidbody;

            if (rb)
            {
                var kart = rb.GetComponent<ArcadeKart>();
                //var kart = rb.GetComponent<Rigidbody>();
                anim.SetTrigger("HIT");

                if (kart && kart.canBeEffected)
                {
                    //rb.constraints = RigidbodyConstraints.FreezeAll;
                    //transform.Rotate(new Vector3(0f, 0f, 1f));
                    //kart.AddPowerup(this.boostStats);
                    //onPowerupActivated.Invoke();
                    stunado = true;
                }
            }
        }
    }

    public void EventToCall()
    {
        StartCoroutine(TimeOver());
    }

    public void SafestPinch()
    {
        rb.constraints = RigidbodyConstraints.None;
        Destroy(transform.parent.gameObject);
    }
    IEnumerator TimeOver()
    {
        yield return new WaitForSeconds(maxTempStun);
        rb.constraints = RigidbodyConstraints.None;
        Destroy(transform.parent.gameObject);
        
    }
   
}
