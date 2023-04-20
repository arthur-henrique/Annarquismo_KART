using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MudarPosPlayer : MonoBehaviour
{
    private void Start()
    {
        MudarPos();
    }

    void MudarPos()
    {
        if (!ModeControl.singlePlayer)
        {
           
            gameObject.transform.position = new Vector3(-4.29f, 1f, -0.98f);

        }
    }
}
