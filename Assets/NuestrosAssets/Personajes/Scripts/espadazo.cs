using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class espadazo : MonoBehaviour
{
    
    //if trigger ataque is true then delete objects that collide with the gameobject

    public bool ataque;
    public Animator anim;
    public GameObject jugador;
    public float delay = 1.0f;
    public float delay2 = 2.0f;
    float timer = 0.0f;
    //private GameObject colisionAtaque;

    public bool Ataque { get => ataque; set => ataque = value; }

    //ataque is true when leftclick is pressed
    private void Start()
    {
        /*colisionAtaque = GameObject.Find("colisionAtaque");
        ataque = colisionAtaque.GetComponent<espadazo>().ataque;*/
    }
    private void Update()
    {
        timer += Time.deltaTime;
        if (Input.GetMouseButtonUp(0))
        {
            if (timer > delay)
            {
                Debug.Log("Ha empezado a atacar");
                Ataque = true;
                anim.SetTrigger("atacar");
            }
        }
        //StartCoroutine(ataqueFalse());
        if (timer > delay2)
        {
            Debug.Log("Ha dejado de atacar!!!!!!!!!!!!");
            Ataque = false;
            timer = 0.0f;
        }
    }

    

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Enemigo")
        {
            //Debug.Log("La espada ha entrado en colision");
            atacar(collision.gameObject);
            if (ataque == true)
            {
                Debug.Log("Esta atacando");
                /* if (gameObject.gameObject.tag == "Enemigo")
                 {*/
                Debug.Log("La espada ha entrado en colision con el enemigo");
                //Debug.Log(collision.gameObject.tag);
                collision.gameObject.GetComponent<statsEnemigos>().Vida -= jugador.GetComponent<statsPlayer>().Danyo;
                Debug.Log("Enemigo se ha hecho daño con espada");
                ataque = false;
                //}
            }
        }
        //ataque = false;
        
    }
   
    private void atacar(GameObject gameObject)
    {
        
        

       

    }

    //Funcion IEenumerator para llamar a la funcion ataqueFalse() despues de pasar 3 segundos
    IEnumerator ataqueFalse()
    {

        yield return new WaitForSeconds(3f);
        ataque = false;

    }





}
