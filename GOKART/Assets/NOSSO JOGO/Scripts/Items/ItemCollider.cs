using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollider : MonoBehaviour
{
    public GameObject[] possibleItems;
    public Image[] spritesItem;
    public GameObject randomItem;
    public Animator anim;
    public MeshRenderer meshRenderer;
    public BoxCollider box;
    public Transform baiacuSpawn;
    public int randomNumber;
    public GameObject crab;
    private Rigidbody rb;
    public int i;

   
    
    



  

    private void OnTriggerEnter(Collider other)
    {
        rb = other.attachedRigidbody;
      
            if (other.CompareTag("Player"))
            {
                 if (ItemHandler.InstanceItemHandler.isFull[i] == false)
                 {


                baiacuSpawn = rb.transform.GetChild(7);
                crab = rb.transform.Find("CaranguejoSpawn").transform.Find("Crab").gameObject;
                randomNumber = Random.Range(0, possibleItems.Length);
                randomItem = possibleItems[randomNumber];
                other.GetComponent<ItemHandler>().HasItem(true, randomItem);
               
                if (randomItem != null)
                {
                    for (i = 0; i < ItemHandler.InstanceItemHandler.slots.Length; i++)
                    {
                        if (ItemHandler.InstanceItemHandler.isFull[i] == false)
                        {

                            ItemHandler.InstanceItemHandler.isFull[i] = true;
                            GameObject sprtiteItem = ItemHandler.InstanceItemHandler.slots[i].transform.GetChild(randomNumber).gameObject;
                            sprtiteItem.SetActive(true);
                            break;
                        }

                    }



                }

                anim.SetTrigger("GOT");


                   
                
            }

            

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
