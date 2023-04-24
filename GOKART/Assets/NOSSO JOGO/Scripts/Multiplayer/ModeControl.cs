using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ModeControl : MonoBehaviour
{
    public static bool singlePlayer;
    public Animator transition;
    public float transitionTime = 1f;
    public string cenaParaCarregar;

    public void UmJogador()
    {
        gameObject.SetActive(true);
        singlePlayer = true;
        StartCoroutine(LoadLevel());
    }
    public void DoisJogadores()
    {
        gameObject.SetActive(true);
        singlePlayer = false;
        StartCoroutine(LoadLevel());
    }


    public void TrocarCena()
    {
        LoadLevel();
    }

    IEnumerator LoadLevel()
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(cenaParaCarregar);
    }
}
