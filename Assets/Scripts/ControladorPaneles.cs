using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorPaneles : MonoBehaviour
{
    [SerializeField] GameObject panelPause;
    [SerializeField] GameObject panelDeJuego;
    [SerializeField] GameObject panelFinalizado;
    [SerializeField] GameObject panelInicio;
    public void MostrarPanelDeJuego()
    {
        panelDeJuego.SetActive(true);
        panelPause.SetActive(false);
        panelFinalizado.SetActive(false);
        panelInicio.SetActive(false);
    }
    public void MostrarFinalizado() {
        panelDeJuego.SetActive(false);
        panelPause.SetActive(false);
        panelFinalizado.SetActive(true);
        panelInicio.SetActive(false);
    }
    public void MostrarPausa() {
        panelDeJuego.SetActive(false);
        panelPause.SetActive(true);
        panelFinalizado.SetActive(false);
        panelInicio.SetActive(false);
    }
    
}
