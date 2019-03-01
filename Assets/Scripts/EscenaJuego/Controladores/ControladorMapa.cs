using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorMapa : ControladorBasico {

    public GameObject elementoInicial;
    
    public Transform puntoInicial;

    public GameObject elementoActual;

    public List<GameObject> mapa;
    // Use this for initialization
    void Start () {
        base.Start();
        mapa = new List<GameObject>();
        encontrarPlataformas();
        //                      GameObject              Position                        Rotation
        var plataformaInicio = Instantiate(elementoInicial, puntoInicial.position, puntoInicial.rotation);
        Transform destino = plataformaInicio.gameObject.transform.Find("PuntoAnclado");
        int numeroAleatorio = Random.Range(0,mapa.Count);
        Debug.Log(numeroAleatorio);
        var elementoAleatorio = mapa[numeroAleatorio];
        elementoActual = Instantiate(elementoAleatorio, destino.position, destino.rotation);
	}
	
    void encontrarPlataformas()
    {
        var plataforma1 = GameObject.Find("Pasillo");
        mapa.Add(plataforma1);
        var plataforma2 = GameObject.Find("Pasillo_Izq");
        mapa.Add(plataforma2);
        var plataforma3 = GameObject.Find("Pasillo_Dcha");
        mapa.Add(plataforma3);
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
