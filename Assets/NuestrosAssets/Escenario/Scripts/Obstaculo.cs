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
            quitarVida(collision.gameObject);
        }
        else if (collision.gameObject.tag == "Enemigo")
        {
            quitarVida(collision.gameObject);
        }

    }

    //----------------------------------------------------------------//
    //--------------------------METODOS-------------------------------//



    void quitarVida(GameObject gameObject)
    {
        if (gameObject.tag == "Jugador")
        {
            if (gameObject.GetComponent<statsPlayer>().Vida > 0)
            {
                gameObject.GetComponent<statsPlayer>().Vida -= danyo;
                Debug.Log("Te han hecho daño");
            }
        }
        else if (gameObject.tag == "Enemigo")
        {
            Debug.Log("Enemigo se ha hecho daño con obstaculo");
        }
        
    }
}
