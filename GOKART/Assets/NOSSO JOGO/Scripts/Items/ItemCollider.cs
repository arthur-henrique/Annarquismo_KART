using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollider : MonoBehaviour
{
    public GameObject[] possibleItems;
    public GameObject randomItem;

   
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            int randomNumber = Random.Range(0, possibleItems.Length);
            randomItem = possibleItems[randomNumber];
            other.GetComponent<ItemHandler>().HasItem(true, randomItem);
            StartCoroutine(ReativarCaixa());
            gameObject.SetActive(false);
            
        }
    }

    IEnumerator ReativarCaixa()
    {
        yield return new WaitForSeconds(2f);
        gameObject.SetActive(true);

    }
}
