using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class espadazo : MonoBehaviour
{
    //if trigger ataque is true then delete objects that collide with the gameobject

    public bool ataque = false;
    public Animator anim;

    //ataque is true when leftclick is pressed

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            anim.SetTrigger("atacar");
            ataque = true;
            
            
        }

    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Enemigo" && ataque == true)
        {
            /*DanyoEnemigo damage = other.GetComponent<DañoEnemigo>();
            if (damage != null)
            {
                damage.TomarDaño(10);
            }*/
        }

        Invoke("ataqueFalse", 0.3f);

    }
    

    private void ataqueFalse()
    {
        ataque = false;
    }

    

}
