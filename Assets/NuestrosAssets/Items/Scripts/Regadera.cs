using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Regadera : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public statsPlayer statsPlayer;
    

    private void OnEnable()
    {
        GameObject jugador = GameObject.Find("Jugador");
        jugador.GetComponent<statsPlayer>().VidaMax = jugador.GetComponent<statsPlayer>().VidaMax + 1;

    }
}
