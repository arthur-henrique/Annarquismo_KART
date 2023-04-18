using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassarVoltas : MonoBehaviour
{
    public int value;
    public CheckpointChecker checkpoint;
    public bool completou, completou2;
    public int numCheckpoint;
    public int pegouCheckpoint, pegouCheckpoint2;


    private void OnTriggerEnter(Collider other)
    {
        var checkarPlayer = other.GetComponent<ItemHandler>();
        if(completou)
        if (checkarPlayer.isPlayer1)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                 VoltasContador.contadorInstance.IncreaseVoltas1(value);
                    completou = false;
            
            }

        }
        if (completou2)
            {
                if (checkarPlayer.isPlayer2)
                {
                    if (other.gameObject.CompareTag("Player"))
                    {
                        VoltasContador.contadorInstance.IncreaseVoltas2(value);
                        completou2 = false;
                    }
                }
            }

    }
}
