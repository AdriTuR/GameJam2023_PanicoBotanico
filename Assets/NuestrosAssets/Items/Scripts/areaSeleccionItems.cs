using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class areaSeleccionItems : MonoBehaviour
{
    
    public GameObject seleccionItemQ;
   
    public GameObject seleccionItemE;

    public GameObject Jugador;
    // Start is called before the first frame update

    void Awake()
    {
        Jugador = GameObject.Find("Jugador");
        seleccionItemQ = GameObject.Find("seleccionItemQ");
        seleccionItemE = GameObject.Find("seleccionItemE");
     
    }

    private void Start()
    {
       
    }
    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject == Jugador)
        {
            Debug.Log("Ha Entrado!!!!!!!!!!!!!!!!!!!");

            seleccionItemQ.SetActive(true);
            seleccionItemE.SetActive(true);

        }

    }

    void OnTriggerExit(Collider other)
    {

        if (other.gameObject == Jugador)
        {
            Debug.Log("!!!!!!!!!!!!!!!!!!!Ha Salido");

            seleccionItemQ.SetActive(false);
            seleccionItemE.SetActive(false);

        }

    }
}
