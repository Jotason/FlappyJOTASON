using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AdministradorJuego : MonoBehaviour
{

    public static AdministradorJuego Instancia;


    public delegate void EventosJuegoDelegado();

    public EventosJuegoDelegado juegoIniciado;
    public EventosJuegoDelegado juegoFinalizado;
    public EventosJuegoDelegado juegoPausado;
    public EventosJuegoDelegado juegoReanudado;
    //public EventosJuegoDelegado juegoReiniciado;

    private void Awake()
    {
        if (Instancia == null)
        {
            Instancia = this;
        }
        else {
            Destroy(gameObject);
        }

    }
    public void IniciarJuego() {
        Time.timeScale = 1;
        juegoIniciado?.Invoke();
    }

    public void PausarJuego()
    {
        Time.timeScale = 0;
        juegoPausado?.Invoke();
    }
    public void ReanudarJuego()
    {
        Time.timeScale = 1;
        juegoReanudado?.Invoke();
    }

    public void FinalizarJuego()
    {
        Time.timeScale = 0;
        juegoFinalizado?.Invoke();
    }
    public void ReiniciarJuego()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void CerrarJuego()
    {
        Application.Quit();
    }
}
