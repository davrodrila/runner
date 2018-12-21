using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorInterfaz : ControladorBasico {

    public GameObject canvasJugando;
    public GameObject canvasPausa;

    // Use this for initialization
    void Start () {
        base.Start();
        juegoRestaurado();
	}
	
	// Update is called once per frame
	void Update () {
    }

    public override void juegoEnPausa()
    {
        canvasJugando.GetComponent<Canvas>().enabled = false;
        canvasPausa.GetComponent<Canvas>().enabled = true;
    }

    public override void juegoRestaurado()
    {
        canvasJugando.GetComponent<Canvas>().enabled = true;
        canvasPausa.GetComponent<Canvas>().enabled = false;
    }
}
