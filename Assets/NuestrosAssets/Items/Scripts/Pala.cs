using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Pala : MonoBehaviour
{
    public float multiplicadorDanyo = 1.3f;
    private GameObject itemPala;
    // Start is called before the first frame update
    void Start()
    {

    }
  
    
    private void OnEnable()
    {
       
        //itemPala.transform.position = GetComponentInParent<GameObject>().transform.position;
        GameObject jugador = GameObject.Find("Jugador");
        jugador.GetComponent<statsPlayer>().Danyo = jugador.GetComponent<statsPlayer>().Danyo * multiplicadorDanyo;

    }



}
