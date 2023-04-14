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
            gameObject.transform.position = new Vector3(-2.77f, 0f, -0.09999999f);
        }
    }
}
