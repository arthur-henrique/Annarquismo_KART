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
    public Transform baiacuSpawn;
    public GameObject crab, imagemItem;
    private Rigidbody rb;
    
  

   
    private void OnTriggerEnter(Collider other)
    {
        rb = other.attachedRigidbody;
        
        if (other.CompareTag("Player"))
        {
            imagemItem.SetActive(true);
            baiacuSpawn = rb.transform.GetChild(7);
            crab = rb.transform.Find("CaranguejoSpawn").transform.Find("Crab").gameObject;
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
