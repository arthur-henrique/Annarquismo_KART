using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public static MenuController instance;
    public string faseParaCarregar;
    public string proximaCena;
    private void Awake()
    {
        instance = this;
        DontDestroyOnLoad(transform.gameObject);
    }
    public void CarregarCena()
    {
        SceneManager.LoadScene(proximaCena);
    }
}
