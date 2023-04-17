using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CanudosColetados : MonoBehaviour
{
    public TMP_Text canudoTexto;
   
    
    void Start()
    {
        canudoTexto.text = "Canudos =  " + ContadorDeCanudo.instance.currentCanudos.ToString();
    }

   
}
