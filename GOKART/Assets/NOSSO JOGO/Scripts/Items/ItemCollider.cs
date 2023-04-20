using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollider : MonoBehaviour
{
    public GameObject[] possibleItems;
    public GameObject randomItem;
    public Animator anim;
    public CinemachineVirtualCamera defaultCam, tubaCam;
    public MeshRenderer meshRenderer;
    public BoxCollider box;
    public Transform baiacuSpawn;
    public int randomNumber;
    public GameObject crab;
    private Rigidbody rb;
    public ItemHandler itemHandler;
    public GameObject tuba;
    GameObject sprtiteItem;














    private void OnTriggerEnter(Collider other)
    {
        rb = other.attachedRigidbody;
        itemHandler = other.GetComponent<ItemHandler>();
        
        
            if (other.CompareTag("Player"))
            {


                    defaultCam = rb.transform.GetChild(4).GetComponent<CinemachineVirtualCamera>();
                    tubaCam = rb.transform.GetChild(8).GetComponent<CinemachineVirtualCamera>();
                    tuba = rb.transform.GetChild(7).gameObject;

                    baiacuSpawn = rb.transform.GetChild(6);
                    crab = rb.transform.Find("CaranguejoSpawn").transform.Find("Crab").gameObject;
                    randomNumber = Random.Range(0, possibleItems.Length);
                    randomItem = possibleItems[randomNumber];
                    other.GetComponent<ItemHandler>().HasItem(true, randomItem);


               
                if (randomItem != null)
                {
                    
                    
                        if (itemHandler.isFull == false)
                        {

                            itemHandler.isFull = true;
                            sprtiteItem = itemHandler.slots.transform.GetChild(randomNumber).gameObject;
                            sprtiteItem.SetActive(true);
                            
                        }

                    



                }

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
