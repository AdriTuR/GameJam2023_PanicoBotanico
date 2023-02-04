using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class areaSeleccionItems : MonoBehaviour
{
    
    public GameObject seleccionItemQ;
   
    public GameObject seleccionItemE;

    public GameObject Jugador;
    // Start is called before the first frame update

    void Start()
    {
        seleccionItemQ.SetActive(false);
        seleccionItemE.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject == Jugador)
        {

            seleccionItemQ.SetActive(true);
            seleccionItemE.SetActive(true);

        }

    }

    void OnTriggerExit(Collider other)
    {

        if (other.gameObject == Jugador)
        {

            seleccionItemQ.SetActive(false);
            seleccionItemE.SetActive(false);

        }

    }
}
