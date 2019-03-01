using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionPlataforma : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        var script_mapa = GameObject.Find("ControladorMapa").GetComponent<ControladorMapa>();
        int numeroAleatorio = Random.Range(0, script_mapa.mapa.Count);
        var elementoAleatorio = script_mapa.mapa[numeroAleatorio];
        var puntoAnclaje = script_mapa.elementoActual.transform.GetChild(1);
        script_mapa.elementoActual = Instantiate(elementoAleatorio, puntoAnclaje.position, puntoAnclaje.rotation);
    }
}
