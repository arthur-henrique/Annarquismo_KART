using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelection : MonoBehaviour
{
    public GameObject[] characterList;
    public int index;
  
   
    

    private void Start()
    {
        index = PlayerPrefs.GetInt("CharacterSelect");
        

        characterList = new GameObject[transform.childCount];
       
       
        //Coloca os obj no array
        for (int i = 0; i < transform.childCount; i++)
        {
            characterList[i] = transform.GetChild(i).gameObject;
        }
        //deixa desligado os modelos
        foreach(GameObject go in characterList)
        {
            go.SetActive(false);
        } 
        //liga o primeiro sprite
        if (characterList[index])
        {
            characterList[index].SetActive(true);
        }
    }
    public void ToggleLeft()
    {
        characterList[index].SetActive(false);
        index--;
        if(index< 0)
        {
            index = characterList.Length - 1;
        }
        characterList[index].SetActive(true);
    }
    public void ToggleRigth()
    {
        characterList[index].SetActive(false);
        index++;
        if (index == characterList.Length)
        {
            index = 0;
        }
        characterList[index].SetActive(true);
    }
    public void ConfirmButton()
    {
        PlayerPrefs.SetInt("CharacterSelect", index);
        SceneManager.LoadScene("MainScene");
    }
}
