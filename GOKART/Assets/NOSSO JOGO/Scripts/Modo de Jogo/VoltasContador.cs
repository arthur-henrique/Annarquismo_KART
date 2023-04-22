using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VoltasContador : MonoBehaviour
{
    public static VoltasContador contadorInstance;


    public TMP_Text lapsTexto1, lapsTexto2;
    public int totalDeVoltas = 4;
    public int currentLaps = 1;
    public int currentLaps2 = 1;
    public Animator transition;
    public float transitionTime = 1f;
    private void Awake()
    {
        contadorInstance = this;
    }
    void Start()
    {
        lapsTexto1.text = currentLaps2.ToString() + "/3";
        lapsTexto2.text = currentLaps.ToString() + "/3";
    }
    private void Update()
    {   

        if (currentLaps == totalDeVoltas || currentLaps2 == totalDeVoltas)
        {
            StartCoroutine(LoadLevel());
        }
        
    }
    public IEnumerator LoadLevel()
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene("WinScene");
    }

        public void IncreaseVoltas1(int v)
    {
        currentLaps += v;
        lapsTexto1.text = currentLaps.ToString() + "/3";
    }
    public void IncreaseVoltas2(int v)
    {
        currentLaps2 += v;
        lapsTexto2.text =  currentLaps2.ToString() + "/3";
    }
}
