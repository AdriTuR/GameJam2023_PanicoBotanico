using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo : MonoBehaviour
{
    //----------------------------------------------------------------//
    //------------------------ATRIBUTOS-------------------------------//
    [SerializeField]
    private int danyo; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Jugador") {
            quitarVida();
        }
       
    }

    //----------------------------------------------------------------//
    //--------------------------METODOS-------------------------------//



    void quitarVida()
    {
        GameObject jugador = GameObject.Find("Jugador");
        if(jugador.GetComponent<statsPlayer>().Vida > 0)
        {
            jugador.GetComponent<statsPlayer>().Vida -= danyo;
            Debug.Log("Te han echo daño");
        }
    }
}
