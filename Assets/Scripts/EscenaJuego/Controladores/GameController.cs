using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Encargado de gestionar el estado del juego
 * 
 */
public class GameController : MonoBehaviour {

    public EstadoJuego estado;
    public List<ControladorBasico> controladores;
    public static GameController controlador;

    /*
     *  https://docs.unity3d.com/Manual/ExecutionOrder.html
     */
    void Awake()
    {
        if (controlador == null)        
            controlador = this;
        else if (controlador != this)
            Destroy(gameObject);
    }

	void Start () {
        controladores = new List<ControladorBasico>();
        estado = EstadoJuego.Jugando;
    }

    void Update () {
		if (Input.GetKeyDown(KeyCode.P))
        {
            if (estado == EstadoJuego.Jugando) { 
                pausarJuego();
            } else if (estado == EstadoJuego.Pausa)
            {
                restaurarJuego();
            }
        }
	}
    void pausarJuego()
    {
        estado = EstadoJuego.Pausa;
        foreach (ControladorBasico c in controladores)
        {
            c.juegoEnPausa();
        }
    }

    void restaurarJuego()
    {
        estado = EstadoJuego.Jugando;
        foreach (ControladorBasico c in controladores)
        {
            c.juegoRestaurado();
        }
    }
    public void registrarControlador(ControladorBasico controlador)
    {
        if (controladores==null)
        {
            controladores = new List<ControladorBasico>();
        }
        controladores.Add(controlador);
    }
}
