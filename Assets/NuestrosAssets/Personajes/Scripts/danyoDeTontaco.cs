using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class danyoDeTontaco : MonoBehaviour
{
    //Tontaco does damage to Jugador on collision, Jugador has his health on statsPlayer

    public int danyo = 1;
    public float tiempoEntreDanyo = 1f;
    public float tiempoDanyo = 0f;

    void OnCollisionStay(Collision obj)
    {
        //al tocar al jugador hace daño
        if (obj.gameObject.tag == "Jugador")
        {
            if (Time.time > tiempoDanyo)
            {
                obj.gameObject.GetComponent<statsPlayer>().vida -= danyo;
                tiempoDanyo = Time.time + tiempoEntreDanyo;
            }
        }
    }




}
