using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class VidaDisplay : MonoBehaviour
{
    
    public GameObject[] petalos;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        SetVida(GameObject.FindGameObjectWithTag("Jugador").GetComponent<statsPlayer>().Vida);
    }

    public void SetVida(int vidaActual)
    {
        for (int i = 0; i < vidaActual; i++)
        {
            petalos[i].SetActive(true);
        }
        for (int i = vidaActual; i < petalos.Length; i++)
        {
            petalos[i].SetActive(false);
        }
    }
}
