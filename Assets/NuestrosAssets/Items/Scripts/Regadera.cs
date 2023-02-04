using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Regadera : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private GameObject itemRegadera;
    private bool hasRun = false;
    private void Update()
    {
        if (itemRegadera.activeSelf == true && hasRun == false)
        {
            hasRun = true;
            GameObject jugador = GameObject.Find("Jugador");
            jugador.GetComponent<statsPlayer>().VidaMax = jugador.GetComponent<statsPlayer>().VidaMax + 1;

            Debug.Log("Vida Máxima Jugador es: " + jugador.GetComponent<statsPlayer>().VidaMax);
            itemRegadera.SetActive(false);
        }
    }
    private void OnEnable()
     {
         itemRegadera = GameObject.Find("itemRegadera");
         //itemRegadera.transform.position = GetComponentInParent<GameObject>().transform.position;
         /*
         GameObject jugador = GameObject.Find("Jugador");
         jugador.GetComponent<statsPlayer>().VidaMax = jugador.GetComponent<statsPlayer>().VidaMax + 1;

         Debug.Log("Vida Máxima Jugador es: " + jugador.GetComponent<statsPlayer>().VidaMax);*/

     }
}
