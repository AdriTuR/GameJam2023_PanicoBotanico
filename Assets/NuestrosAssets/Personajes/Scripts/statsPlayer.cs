using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class statsPlayer : MonoBehaviour
{
    //Stats para el jugador de vida, vida máxima, ataque, velocidad de movimiento, velocidad de ataque, tamaño y suerte
    // Variables de estadísticas del jugador
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
    [SerializeField]
    private bool espinas;
    private GameObject jugador;
  
    private bool gameIsPaused;
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
    public bool Espinas { get => espinas; set => espinas = value; }
    GameObject pantallaPausa;
    GameObject pantallaDerrota;

    private void Awake()
    {
        Time.timeScale = 1;
    }
    void Start()
    {
        jugador = GameObject.Find("Jugador");
        // Inicializar las estadísticas del jugador aquí
        VidaMax = 6;
        Vida = 6;
        Danyo = 5;
        Espinas = false;
        pantallaPausa = GameObject.Find("PANTALLA PAUSA");
        pantallaPausa.SetActive(false);
        pantallaDerrota = GameObject.Find("PANTALLA Has muerto");
        pantallaDerrota.SetActive(false);
    }

    void Update()
    {
        // Controlar la salud del jugador aquí
        if (vida > vidaMax)
        {
            Vida = VidaMax;
        }
        if (Espinas == true)
        {
            jugador.GetComponent<espinasJugador>().enabled = true;
        }
        if (vida == 0)
        {
            Time.timeScale = 0;
            pantallaDerrota.SetActive(true);
            if (Input.GetKeyDown(KeyCode.R))
            {
                pantallaDerrota.SetActive(false);
                Time.timeScale = 1;

                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            gameIsPaused = !gameIsPaused;
            
            PauseGame();
        }
    }

    void PauseGame()
    {
        if (gameIsPaused)
        {
            Time.timeScale = 0f;
            pantallaPausa.SetActive(true);
        }
        else
        {
            Time.timeScale = 1;
            pantallaPausa.SetActive(false);

        }
    }

}