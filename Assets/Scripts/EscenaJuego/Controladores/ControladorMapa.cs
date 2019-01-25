using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorMapa : ControladorBasico {

    public GameObject elementoInicial;
    public GameObject elementoSiguiente;
    public Transform puntoInicial;

    // Use this for initialization
    void Start () {
        base.Start();
//                      GameObject              Position                        Rotation
        var plataformaInicio = Instantiate(elementoInicial, puntoInicial.position, puntoInicial.rotation);
        Transform destino = plataformaInicio.gameObject.transform.Find("PuntoAnclado");
        Instantiate(elementoSiguiente, destino.position, destino.rotation);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public override void juegoEnPausa()
    {
        
    }

    public override void juegoRestaurado()
    {
        
    }
}
