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
        StartCoroutine(DelayedAction());

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

    private IEnumerator DelayedAction()
    {
        yield return new WaitForSeconds(1);
        //print("I was printed after a delay of 5 seconds!");
    }



}
