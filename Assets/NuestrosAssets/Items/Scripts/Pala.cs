using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Pala : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
   public statsPlayer statsPlayer;
    public int multiplicadorDanyo;

    private void OnEnable()
    {
        GameObject jugador = GameObject.Find("Jugador");
        jugador.GetComponent<statsPlayer>().Danyo = jugador.GetComponent<statsPlayer>().Danyo * multiplicadorDanyo;

    }



}
