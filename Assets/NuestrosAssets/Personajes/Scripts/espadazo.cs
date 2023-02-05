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
            Debug.Log("Ha empezado a atacar");
            Ataque = true;
            anim.SetTrigger("atacar");
        }
        //StartCoroutine(ataqueFalse());
        if (timer > delay)
        {
            Debug.Log("Ha dejado de atacar!!!!!!!!!!!!");
            Ataque = false;
            timer = 0.0f;
        }
    }

    

    private void OnTriggerStay(Collider collision)
    {
        Debug.Log("COLISIONA CON: "+collision.tag);
        //Debug.Log("La espada ha entrado en colision");
        atacar(collision.gameObject);

        //ataque = false;
        
    }
   
    private void atacar(GameObject gameObject)
    {
        
        if (ataque == true)
        {
            Debug.Log("Esta atacando");
            if (gameObject.gameObject.tag == "Enemigo")
            {
                Debug.Log("La espada ha entrado en colision con el enemigo");
                //Debug.Log(collision.gameObject.tag);
                gameObject.gameObject.GetComponent<statsEnemigos>().Vida -= jugador.GetComponent<statsPlayer>().Danyo;
                Debug.Log("Enemigo se ha hecho da�o con espada");
                ataque = false;
            }
        }

       

    }

    //Funcion IEenumerator para llamar a la funcion ataqueFalse() despues de pasar 3 segundos
    IEnumerator ataqueFalse()
    {

        yield return new WaitForSeconds(3f);
        ataque = false;

    }





}
