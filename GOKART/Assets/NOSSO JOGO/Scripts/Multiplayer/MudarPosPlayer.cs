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
           
            gameObject.transform.position = new Vector3(-6.01f, 0.56f, -1.46f);

        }
    }
}
