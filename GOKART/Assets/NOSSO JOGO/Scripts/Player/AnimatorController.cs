using KartGame.KartSystems;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorController : MonoBehaviour
{
    public Animator anim;
    public bool isNadando, isNocauteado, isDrifting;
    public int driftSide;
    public ArcadeKart kart;

    private void FixedUpdate()
    {
        if(kart.currentSpeed > 1)
        {
            isNadando = true;
            anim.SetBool("isNadando", isNadando);
        }
        else
        {
            isNadando = false;
            anim.SetBool("isNadando", isNadando);
        }

        if(kart.IsDrifting)
        {
            isDrifting = true;
            driftSide = kart.driftSide;
            anim.SetBool("isDrifting", isDrifting);
            anim.SetFloat("driftSide", driftSide);
        }
        else
        {
            isDrifting = false;
            anim.SetBool("isDrifting", isDrifting);
        }
    }

    public void BeginStun()
    {
        isNocauteado = true;
        anim.SetBool("isNocauteado", isNocauteado);
    }

    public void FinishStun()
    {
        isNocauteado = false;
        anim.SetBool("isNocauteado", isNocauteado);
    }

}
