using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UICharacterSelec : MonoBehaviour
{
    RectTransform posUI;
    public Vector3 newPos;
    // Start is called before the first frame update
    private void Awake()
    {
        posUI = gameObject.GetComponent<RectTransform>();
    }
    void Start()
    {
        MoverUI();
    }

    void MoverUI()
    {

        if (!ModeControl.singlePlayer)
        {
            posUI.anchoredPosition = newPos;

        }
    }
}
