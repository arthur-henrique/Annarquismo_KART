using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class characterList2 : MonoBehaviour
{

    public GameObject[] characterList;
    public int index2;
    public Animator transition;
    public float transitionTime = 1f;







    private void Start()
    {
        index2 = PlayerPrefs.GetInt("CharacterSelect2");


        characterList = new GameObject[transform.childCount];
       



        //Coloca os obj no array
        for (int i = 0; i < transform.childCount; i++)
        {
            characterList[i] = transform.GetChild(i).gameObject;
        }


        //deixa desligado os modelos
        foreach (GameObject go in characterList)
        {
            go.SetActive(false);
        }
        //liga o primeiro sprite
        if (characterList[index2])
        {
            characterList[index2].SetActive(true);
        }

    }
    public void ToggleLeft()
    {
        characterList[index2].SetActive(false);
        index2--;
        if (index2 < 0)
        {
            index2 = characterList.Length - 1;
        }
        characterList[index2].SetActive(true);
    }
    public void ToggleRigth()
    {
        characterList[index2].SetActive(false);
        index2++;
        if (index2 == characterList.Length)
        {
            index2 = 0;
        }
        characterList[index2].SetActive(true);
    }
    public void ConfirmButton()
    {
        PlayerPrefs.SetInt("CharacterSelect", index2);
        StartCoroutine(LoadLevel());
    }
    public IEnumerator LoadLevel()
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(MenuController.instance.faseParaCarregar);
    }
    public void Botao0()
    {
        characterList[index2].SetActive(false);
        index2 = 0;
        characterList[index2].SetActive(true);
    }
    public void Botao1()
    {
        characterList[index2].SetActive(false);
        index2 = 1;
        characterList[index2].SetActive(true);
    }
    public void Botao2()
    {
        characterList[index2].SetActive(false);
        index2 = 2;
        characterList[index2].SetActive(true);
    }
    public void Botao3()
    {
        characterList[index2].SetActive(false);
        index2 = 3;
        characterList[index2].SetActive(true);
    }
    public void Botao4()
    {
        characterList[index2].SetActive(false);
        index2 = 4;
        characterList[index2].SetActive(true);
    }
    public void Botao5()
    {
        characterList[index2].SetActive(false);
        index2 = 5;
        characterList[index2].SetActive(true);
    }
}
