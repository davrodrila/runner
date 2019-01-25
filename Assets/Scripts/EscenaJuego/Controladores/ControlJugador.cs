using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlJugador : ControladorBasico {

    Animator animator;

    public GameObject posicionCentro, posicionIzquierda, posicionDerecha;


    public EstadoJugador estado;
    private Vector3 destino;
	// Use this for initialization
	void Start () {
        base.Start();
        animator = GetComponent<Animator>();
        estado = EstadoJugador.Centro;
        destino = gameObject.transform.position;
    }
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetBool(Utils.ANIMATION_SALTANDO,true);
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            animator.SetBool(Utils.ANIMATION_AGACHADO, true);
        }
        
        if (Input.GetKeyDown(KeyCode.A))
        {
            if (estado == EstadoJugador.Derecha)
            {
                destino = posicionCentro.transform.position;
                estado = EstadoJugador.Transicion;

            } else if (estado == EstadoJugador.Centro)
            {
                destino = posicionIzquierda.transform.position;
                estado = EstadoJugador.Transicion;
            }
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            if (estado == EstadoJugador.Izquierda)
            {
                destino = posicionCentro.transform.position;
                estado = EstadoJugador.Transicion;
            }
            if (estado == EstadoJugador.Centro)
            {
                destino = posicionDerecha.transform.position;
                estado = EstadoJugador.Transicion;
            }
        }
        if (estado == EstadoJugador.Transicion)
        {
            if (transform.position.x > destino.x)
            {
                transform.position = new Vector3(transform.position.x - 1, transform.position.y);
            }
            else if (transform.position.x < destino.x)
            {
                transform.position = new Vector3(transform.position.x + 1, transform.position.y);
            }
        }
 	}

    void finalizarAnimacion()
    {
        animator.SetBool(Utils.ANIMATION_SALTANDO, false);
    }

    void finalizarAgachado()
    {
        animator.SetBool(Utils.ANIMATION_AGACHADO, false);
    }

    public override void juegoEnPausa()
    {
        Time.timeScale = 0f;
    }

    public override void juegoRestaurado()
    {
        Time.timeScale = 1f;
    }
    public void OnTriggerEnter(Collider other)
    {
        
        if (other.name=="Central")
        {
            estado = EstadoJugador.Centro;
        } else if (other.name=="Dcha")
        {
            estado = EstadoJugador.Derecha;
        } else if (other.name == "Izq")
        {
            estado = EstadoJugador.Izquierda;
        }
    }
}
