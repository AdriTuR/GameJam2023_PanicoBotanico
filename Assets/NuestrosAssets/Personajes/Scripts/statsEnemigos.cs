using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class statsEnemigos : MonoBehaviour
{

    //Stats para el jugador de vida, vida máxima, ataque, velocidad de movimiento, velocidad de ataque, tamaño y suerte
    // Variables de estadísticas del jugador
    [SerializeField]
    private float danyo;
    [SerializeField]
    private int vidaMax;
    [SerializeField]
    public float vida;
    [SerializeField]
    public float velocidadMovimiento;
    [SerializeField]
    private float velocidadAtaque;
    [SerializeField]
    private float nockbackeo;
    [SerializeField]
    private float dashCooldown;

    public float Danyo { get => danyo; set => danyo = value; }
    public int VidaMax { get => vidaMax; set => vidaMax = value; }
    public float Vida { get => vida; set => vida = value; }
    public float VelocidadMovimiento { get => velocidadMovimiento; set => velocidadMovimiento = value; }
    public float VelocidadAtaque { get => velocidadAtaque; set => velocidadAtaque = value; }
    public float Nockbackeo { get => nockbackeo; set => nockbackeo = value; }
    public float DashCooldown { get => dashCooldown; set => dashCooldown = value; }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        morir();
    }

    void atacarJugador()
    {
        
    }

    void morir()
    {
        if(vida <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
