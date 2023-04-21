using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public static MenuController instance;
    public string faseParaCarregar;
    public string proximaCena;
    public Animator transition;
 
    public float transitionTime = 1f;
    private void Awake()
    {
        instance = this;
        DontDestroyOnLoad(transform.gameObject);
    }
    public void CarregarCena()
    {
        
        StartCoroutine(LoadLevel());
    }
    public IEnumerator LoadLevel()
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(proximaCena);
    }
}
