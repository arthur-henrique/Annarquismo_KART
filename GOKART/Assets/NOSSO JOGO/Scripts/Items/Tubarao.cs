using KartGame.KartSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class Tubarao : MonoBehaviour, IUsable
{
    public GameObject tubaObj;
    public CinemachineVirtualCamera defaultCam, tubaCam;


    public void Use(ArcadeKart kart)
    {
        tubaObj.SetActive(true);
        defaultCam.Priority = 0;
        tubaCam.Priority = 10;
    }

    IEnumerator Destubarar()
    {
        yield return new WaitForSecondsRealtime(3f);
        tubaObj.SetActive(false);
        defaultCam.Priority = 10;
        tubaCam.Priority = 0;
    }

   
}
