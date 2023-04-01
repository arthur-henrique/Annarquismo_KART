using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollider : MonoBehaviour
{
    public GameObject[] possibleItems;
    public GameObject randomItem;
    public Animator anim;
    public MeshRenderer meshRenderer;
    public BoxCollider box;

   
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            int randomNumber = Random.Range(0, possibleItems.Length);
            randomItem = possibleItems[randomNumber];
            other.GetComponent<ItemHandler>().HasItem(true, randomItem);
            anim.SetTrigger("GOT");
            
        }
    }

    public void TurnItOnOff()
    {
        StartCoroutine(ReativarCaixa());
        box.enabled = false;
        meshRenderer.enabled = false;
    }

    IEnumerator ReativarCaixa()
    {
        yield return new WaitForSeconds(2f);
        anim.Rebind();
        box.enabled = true;
        meshRenderer.enabled = true;

    }
}
