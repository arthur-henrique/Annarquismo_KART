using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelection : MonoBehaviour
{
    public GameObject[] characterList;
   
    public int index;
    public Camera cam1, cam2;
   
    
   
    

    private void Start()
    {
        index = PlayerPrefs.GetInt("CharacterSelect");
        

        characterList = new GameObject[transform.childCount];
        if (ModeControl.singlePlayer)
        {
            cam1.rect = new Rect(0, 0, 1, 1);
            Destroy(GameObject.Find("List2"));
            
        }
        else
        {
            
            cam1.rect = new Rect(0, 0.5f, 1, 0.5f);
            cam2.rect = new Rect(0, 0, 1, 0.5f);
        }

       
        
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
        SceneManager.LoadScene(MenuController.instance.faseParaCarregar);
    }
    public void Botao0()
    {
        characterList[index].SetActive(false);
        index = 0;
        characterList[index].SetActive(true);
    }
    public void Botao1()
    {
        characterList[index].SetActive(false);
        index = 1;
        characterList[index].SetActive(true);
    }
    public void Botao2()
    {
        characterList[index].SetActive(false);
        index = 2;
        characterList[index].SetActive(true);
    }
    public void Botao3()
    {
        characterList[index].SetActive(false);
        index = 3;
        characterList[index].SetActive(true);
    }
    public void Botao4()
    {
        characterList[index].SetActive(false);
        index = 4;
        characterList[index].SetActive(true);
    }
    public void Botao5()
    {
        characterList[index].SetActive(false);
        index = 5;
        characterList[index].SetActive(true);
    }
}
