using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ModeControl : MonoBehaviour
{
    public static bool singlePlayer;
    public Animator transition;
    public float transitionTime = 1f;

    public void UmJogador()
    {
        singlePlayer = true;
        StartCoroutine(LoadLevel());
    }
    public void DoisJogadores()
    {
        singlePlayer = false;
        StartCoroutine(LoadLevel());
    }

    IEnumerator LoadLevel()
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene("FaseSelection");
    }
}
