using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarregarCena : MonoBehaviour
{
    public Animator transicao;
    public void CenaParaCarregar()
    {
        
        SceneManager.LoadScene("IntroMenu");

    }
}
