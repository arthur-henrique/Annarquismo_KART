using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeaLight : MonoBehaviour
{
    float randomAmount;
    public float velocidade;
    private void Start()
    {
        InvokeRepeating("Mudanca", 0, 3);
    }
    void Update()
    {
        

        //gameObject.transform.Translate(Vector3.forward * Time.deltaTime * 5);
        gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, gameObject.transform.position + (new Vector3(randomAmount, randomAmount, randomAmount)), 0.002f);
        gameObject.transform.eulerAngles = Vector3.Lerp(gameObject.transform.eulerAngles, gameObject.transform.eulerAngles - (new Vector3(0, randomAmount, 0)), 0.002f);
    }

    void Mudanca()
    {
        randomAmount  = Random.Range(1, 2);
    }
}
