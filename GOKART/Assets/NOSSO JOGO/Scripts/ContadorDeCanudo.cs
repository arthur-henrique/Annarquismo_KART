using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ContadorDeCanudo : MonoBehaviour
{
    public static ContadorDeCanudo instance;

    public TMP_Text canudoTexto, canudoTexto2;
    public int currentCanudos = 0, currentCanudos2 = 0;
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        canudoTexto.text = "x" + currentCanudos.ToString();
        canudoTexto2.text = "x" + currentCanudos2.ToString();
    }

    public void IncreaseCanudos(int v)
    {
        currentCanudos += v;
        canudoTexto.text = "x" + currentCanudos.ToString();
    }
    public void IncreaseCanudos2(int v)
    {
        currentCanudos2 += v;
        canudoTexto2.text = "x" + currentCanudos2.ToString();
    }
}
