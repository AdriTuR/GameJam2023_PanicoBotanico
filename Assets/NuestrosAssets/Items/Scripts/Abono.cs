using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Abono : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private GameObject itemAbono;
    


    private void OnEnable()
    {
        /*itemAbono = GameObject.Find("itemAbono");
        itemAbono.transform.position = GetComponentInParent<GameObject>().transform.position;*/
        GameObject jugador = GameObject.Find("Jugador");
        jugador.GetComponent<statsPlayer>().VelocidadMovimiento = jugador.GetComponent<statsPlayer>().VelocidadMovimiento * 0.8f;
        jugador.GetComponent<statsPlayer>().VidaMax = jugador.GetComponent<statsPlayer>().VidaMax + 1;
        jugador.GetComponent<statsPlayer>().Danyo = jugador.GetComponent<statsPlayer>().Danyo * 1.3f;
        jugador.GetComponent<statsPlayer>().Nockbackeo = jugador.GetComponent<statsPlayer>().Nockbackeo * 0.7f;
        jugador.GetComponent<statsPlayer>().DashCooldown = jugador.GetComponent<statsPlayer>().DashCooldown * 1.3f;
    }
}
