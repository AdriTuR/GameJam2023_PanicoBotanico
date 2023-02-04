using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class movTontaco : MonoBehaviour
{
    //NavmeshAgent follows Jugador

    public Transform Jugador;
    public float speed = 5f;
    public float stoppingDistance = 10f;
    public float retreatDistance = 5f;
    

    private void Start()
    {
        Jugador = GameObject.FindGameObjectWithTag("Jugador").transform;
    }

    private void Update()
    {
        GetComponent<NavMeshAgent>().destination = Jugador.transform.position;
    }

    void OnCollisionStay(Collision obj)
    {
        //al tocar al jugador para de moverse
        
        
        
    }


}
