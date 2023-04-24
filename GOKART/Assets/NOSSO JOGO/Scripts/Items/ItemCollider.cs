using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollider : MonoBehaviour
{
    public static ItemCollider instanceCollider;
    public GameObject[] possibleItems;
    public GameObject randomItem;
    public Animator anim;
    public CinemachineVirtualCamera defaultCam, tubaCam;
    public MeshRenderer meshRenderer;
    public BoxCollider box;
    public GameObject baiacuSpawn;
    public int randomNumber;
    public GameObject crab;
    public Rigidbody rb;
    public ItemHandler itemHandler;
    public GameObject tuba;
    GameObject sprtiteItem;

    private void Awake()
    {
        instanceCollider = this;
    }

    private void OnTriggerEnter(Collider other)
    {
        rb = other.attachedRigidbody;
        itemHandler = other.GetComponent<ItemHandler>();

        if (!itemHandler._hasItem)
        {


            if (other.CompareTag("Player"))
            {


                defaultCam = rb.transform.GetChild(4).GetComponent<CinemachineVirtualCamera>();
                tubaCam = rb.transform.GetChild(7).GetComponent<CinemachineVirtualCamera>();
                tuba = rb.transform.GetChild(6).gameObject;

                baiacuSpawn = rb.transform.Find("FirePoint").transform.Find("Pufferfish").gameObject;
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
        else
        {
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
