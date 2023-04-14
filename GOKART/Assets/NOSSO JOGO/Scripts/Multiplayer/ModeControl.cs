using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ModeControl : MonoBehaviour
{
    public static bool singlePlayer;

    public void UmJogador()
    {
        singlePlayer = true;
        SceneManager.LoadScene("FaseSelection");
    }
    public void DoisJogadores()
    {
        singlePlayer = false;
        SceneManager.LoadScene("FaseSelection");
    }
}
