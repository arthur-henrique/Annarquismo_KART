using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Geiser : MonoBehaviour
{
    private Rigidbody _playerRigBod;
    public float modifier;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            _playerRigBod = other.GetComponentInParent<Rigidbody>();
            print("HasRig");
            _playerRigBod.AddForce(Vector3.up * modifier);
        }
    }
}
