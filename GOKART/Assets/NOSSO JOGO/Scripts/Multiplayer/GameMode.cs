using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMode : MonoBehaviour
{
    public Camera cam1, cam2;
    private void Awake()
    {
        PlayMode();
    }
    private void PlayMode()
    {
         if(ModeControl.singlePlayer)
        {
            cam1.rect = new Rect(0, 0, 1, 1);
            Destroy(GameObject.Find("Player2"));
        }
        else
        {
            cam1.rect = new Rect(0, 0.5f, 1, 0.5f);
            cam2.rect = new Rect(0, 0, 1, 0.5f);
        }
    }
}
