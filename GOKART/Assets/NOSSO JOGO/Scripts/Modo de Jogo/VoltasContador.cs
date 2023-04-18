using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class VoltasContador : MonoBehaviour
{
    public static VoltasContador contadorInstance;


    public TMP_Text lapsTexto1, lapsTexto2;
    private int totalDeVoltas = 3;
    public int currentLaps = 0;
    public int currentLaps2 = 0;
    private void Awake()
    {
        contadorInstance = this;
    }
    void Start()
    {
        lapsTexto1.text = "Laps: " + currentLaps.ToString();
        lapsTexto2.text = "Laps: " + currentLaps2.ToString();
    }

    public void IncreaseVoltas1(int v)
    {
        currentLaps += v;
        lapsTexto1.text = "Laps: " + currentLaps.ToString();
    }
    public void IncreaseVoltas2(int v)
    {
        currentLaps2 += v;
        lapsTexto2.text = "Laps: " + currentLaps2.ToString();
    }
}
