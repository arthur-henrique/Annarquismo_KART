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
           
            gameObject.transform.position = new Vector3(-5.81f, -1.17f, -1.46f);

        }
    }
}
