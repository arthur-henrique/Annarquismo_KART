using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ContadorDeCanudo : MonoBehaviour
{
    public static ContadorDeCanudo instance;

    public TMP_Text canudoTexto;
    public int currentCanudos = 0;
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        canudoTexto.text = "Canudos: " + currentCanudos.ToString();
    }

    public void IncreaseCanudos(int v)
    {
        currentCanudos += v;
        canudoTexto.text = "Canudos: " + currentCanudos.ToString();
    }
}
