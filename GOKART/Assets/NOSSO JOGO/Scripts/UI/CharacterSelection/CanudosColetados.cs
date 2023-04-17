using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CanudosColetados : MonoBehaviour
{
    public TMP_Text canudoTexto;
    public int canudosPegos;
   
    
    void Start()
    {
        canudosPegos = ContadorDeCanudo.instance.currentCanudos;
        canudoTexto.text = "Canudos =  " + canudosPegos.ToString();
    }

   
}
