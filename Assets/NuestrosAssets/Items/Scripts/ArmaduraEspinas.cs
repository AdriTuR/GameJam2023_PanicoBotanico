using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmaduraEspinas : MonoBehaviour
{
    private GameObject itemArmaduraEspinas;
    private bool hasRun = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) == true && hasRun == false)
        {
            hasRun = true;
            GameObject jugador = GameObject.Find("Jugador");
            jugador.GetComponent<statsPlayer>().Espinas = true;
            
            Debug.Log("El Jugador adquiere espinas: " + jugador.GetComponent<statsPlayer>().Espinas);
            itemArmaduraEspinas.SetActive(false);
        }
    }
        
    private void OnEnable()
    {
        itemArmaduraEspinas = GameObject.Find("itemArmaduraEspinas");
    }
}
