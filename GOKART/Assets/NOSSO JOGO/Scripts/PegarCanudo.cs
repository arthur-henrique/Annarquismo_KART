using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PegarCanudo : MonoBehaviour
{
    Rigidbody rb;
    public int value;
    
   
    private void OnTriggerEnter(Collider other)
    {
        rb = other.attachedRigidbody;
        var checkarPlayer = other.GetComponent<ItemHandler>();
        if (checkarPlayer.isPlayer1)
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            ContadorDeCanudo.instance.IncreaseCanudos(value);
        }
        if (checkarPlayer.isPlayer2)
            if (other.gameObject.CompareTag("Player"))
            {
                Destroy(gameObject);
                ContadorDeCanudo.instance.IncreaseCanudos2(value);
            }


    }
}
