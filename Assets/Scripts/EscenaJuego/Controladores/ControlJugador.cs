using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlJugador : ControladorBasico {

    Animator animator;
	// Use this for initialization
	void Start () {
        base.Start();
        animator = GetComponent<Animator>();
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
}
