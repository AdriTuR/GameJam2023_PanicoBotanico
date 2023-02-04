using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class statsPlayer : MonoBehaviour
{
    //Stats para el jugador de vida, vida máxima, ataque, velocidad de movimiento, velocidad de ataque, tamaño y suerte
    // Variables de estadísticas del jugador
    public float danyo;
    public int vidaMax;
    public int vida;
    public float velocidadMovimiento;
    public float velocidadAtaque;
    public float suerte;
    public float tamanyoPlayer;
    public float nockbackeo;
    public float dashCooldown;

    // Getters y setters para las estadísticas del jugador
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
        // Inicializar las estadísticas del jugador aquí
        VidaMax = 6;
        Vida = 6;
        
        
    }

    void Update()
    {
        // Controlar la salud del jugador aquí
        if (vida > vidaMax)
        {
            
        }
    }

}
