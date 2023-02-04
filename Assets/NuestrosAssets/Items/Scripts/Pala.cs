using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Pala : MonoBehaviour
{
    public float multiplicadorDanyo = 1.3f;
    private GameObject itemPala;
    private bool hasRun = false;

    // Start is called before the first frame update
    void Start()
    {
        multiplicadorDanyo = 1.3f;
    }
    private void Update()
    {
        if (itemPala.activeSelf == true && hasRun == false)
        {
            hasRun = true;
            GameObject jugador = GameObject.Find("Jugador");
            jugador.GetComponent<statsPlayer>().Danyo = jugador.GetComponent<statsPlayer>().Danyo * multiplicadorDanyo;
            Debug.Log("Daño del Jugador es: " + jugador.GetComponent<statsPlayer>().Danyo);
            itemPala.SetActive(false);
        }
    }
    private void OnEnable()
    {
       
        //itemPala.transform.position = GetComponentInParent<GameObject>().transform.position;
        
        itemPala = GameObject.Find("itemPala");


    }



}
