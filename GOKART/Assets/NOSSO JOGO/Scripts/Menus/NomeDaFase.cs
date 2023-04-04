using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NomeDaFase : MonoBehaviour
{
    public string fase;

    public void CarregarFase()
    {
        MenuController.instance.faseParaCarregar = fase;
    }
}
