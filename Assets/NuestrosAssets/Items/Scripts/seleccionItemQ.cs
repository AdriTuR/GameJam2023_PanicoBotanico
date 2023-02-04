using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seleccionItemQ : MonoBehaviour
{
    public GameObject itemQ;

    // Start is called before the first frame update
    void Start()
    {
        itemQ.SetActive(false);
    }

    private void OnEnable()
    {
        itemQ.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        if (isActiveAndEnabled)
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                itemQ.SetActive(true);
            }
        }
    }
}
