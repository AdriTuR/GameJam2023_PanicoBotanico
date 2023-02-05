using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class danyoDeTontaco : MonoBehaviour
{
    //Tontaco does damage to Jugador on collision, Jugador has his health on statsPlayer

    public int danyo = 1;
    public float tiempoEntreDanyo = 8f;
    public float tiempoDanyo = 0f;
    public bool tocadoPrimeraVez = false;
    void OnCollisionStay(Collision obj)
    {
        
        //al tocar al jugador hace daño
        if (obj.gameObject.tag == "Jugador")
        {
            if (tocadoPrimeraVez == false)
            {
                StartCoroutine(DelayedAction());
                Debug.Log("UBEBUBEN PRIMERO!!!!");
                tocadoPrimeraVez = true;
            }
            Debug.Log("UBEBUBEN SEGUNDO!!!!");

            if (Time.time > tiempoDanyo)
            {
                obj.gameObject.GetComponent<statsPlayer>().vida -= danyo;
                tiempoDanyo = Time.time + tiempoEntreDanyo;
            }
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        tocadoPrimeraVez = false;
    }

    private IEnumerator DelayedAction()
    {
        yield return new WaitForSeconds(3);
        print("I was printed after a delay of 3 seconds!");
    }

}
