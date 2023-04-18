using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CanudosColetados : MonoBehaviour
{
    public TMP_Text canudoTexto;
    public int canudosPegos;
    public ContadorDeCanudo contador;
   
    
    void Start()
    {
        canudosPegos = contador.currentCanudos;
        canudoTexto.text = "Canudos =  " + canudosPegos.ToString();
    }

   
}
