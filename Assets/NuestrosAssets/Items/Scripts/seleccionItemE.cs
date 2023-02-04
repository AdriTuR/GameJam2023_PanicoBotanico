using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seleccionItemE : MonoBehaviour
{
    public GameObject itemE;

    // Start is called before the first frame update
    void Start()
    {
        itemE.SetActive(false);
    }

    private void OnEnable()
    {
        itemE.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (isActiveAndEnabled)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                itemE.SetActive(true);
            }
        }
    }
}
