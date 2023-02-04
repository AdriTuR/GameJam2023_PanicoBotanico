using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class statsPlayer : MonoBehaviour
{
    //Stats para el jugador de vida, vida m�xima, ataque, velocidad de movimiento, velocidad de ataque, tama�o y suerte
    // Variables de estad�sticas del jugador
    [SerializeField]
    private float danyo;
    [SerializeField]
    private int vidaMax;
    [SerializeField]
    public int vida;
    [SerializeField]
    public float velocidadMovimiento;
    [SerializeField]
    private float velocidadAtaque;
    [SerializeField]
    private float suerte;
    [SerializeField]
    private float tamanyoPlayer;
    [SerializeField]
    private float nockbackeo;
    [SerializeField]
    private float dashCooldown;

    // Getters y setters para las estad�sticas del jugador
    public float Danyo { get => danyo; set => danyo = value; }
    public int VidaMax { get => vidaMax; set => vidaMax = value; }
    public int Vida { get => vida; set => vida = value; }
    public float VelocidadMovimiento { get => velocidadMovimiento; set => velocidadMovimiento = value; }
    public float VelocidadAtaque { get => velocidadAtaque; set => velocidadAtaque = value; }
    public float Suerte { get => suerte; set => suerte = value; }
    public float TamanyoPlayer { get => tamanyoPlayer; set => tamanyoPlayer = value; }
    public float Nockbackeo { get => nockbackeo; set => nockbackeo = value; }
    public float DashCooldown { get => dashCooldown; set => dashCooldown = value; }

    void Start()
    {
        // Inicializar las estad�sticas del jugador aqu�
        VidaMax = 5;
        Vida = 6;
        Danyo = 5;


    }

    void Update()
    {
        // Controlar la salud del jugador aqu�
        if (vida > vidaMax)
        {

        }
    }

}