using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class espinasJugador : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionStay(Collision obj)
    {
        if (obj.gameObject.tag == "Enemigo")
        {
           // obj.gameObject.GetComponent<statsEnemigos>().Vida -= 20;
        }
    }
}
