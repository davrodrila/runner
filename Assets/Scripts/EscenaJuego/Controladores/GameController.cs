using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Encargado de gestionar el estado del juego
 * 
 */
public class GameController : MonoBehaviour {

    private EstadoJuego estado;
    public List<ControladorBasico> controladores;
    public static GameController controlador;

    /*
     *  https://docs.unity3d.com/Manual/ExecutionOrder.html
     */
    void Awake()
    {
        controlador = new GameController();
    }

	void Start () {
        controladores = new List<ControladorBasico>();
	}

    void Update () {
		if (Input.GetKeyDown(KeyCode.P))
        {
        
            pausarJuego();
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
    public void registrarControlador(ControladorBasico controlador)
    {
        Debug.Log(controlador);
        controladores.Add(controlador);
    }
}
