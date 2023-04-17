using KartGame.KartSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldColl : MonoBehaviour
{
    public Shield shield;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Shark"))
        {
            StartCoroutine(SafeToDeactivate());
        }
        
        else if (other.CompareTag("Obstaculos"))
        {
            Destroy(other.gameObject);
            shield.ShieldIsDown();
        }
    }

    IEnumerator SafeToDeactivate()
    {
        yield return new WaitForSecondsRealtime(0.5f);
        shield.ShieldIsDown();
    }
}
