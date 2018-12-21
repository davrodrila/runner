using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ControladorBasico : MonoBehaviour {

	// Use this for initialization
	public void Start () {
        GameController.controlador.registrarControlador(this);
    }

    public abstract void juegoEnPausa();
    public abstract void juegoRestaurado();
}
