using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class KeyConfig : MonoBehaviour {
    public Button botonSalto;
    public Canvas panel;
    private Boolean esperarATeclaDeSalto= false;

	// Use this for initialization
	void Start () {
        botonSalto.onClick.AddListener(jumpRebind);
        panel.enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
        botonSalto.GetComponentInChildren<Text>().text = ValorOpciones.JUMP_BUTTON.ToString();
    }

    void jumpRebind()
    {
        panel.enabled = true;
        esperarATeclaDeSalto = true;
    }

    private void OnGUI()
    {
        var evento = Event.current;
        if (evento.isKey && esperarATeclaDeSalto)
        {
            Debug.Log("Pulsado: " + evento.keyCode);
            ValorOpciones.JUMP_BUTTON = evento.keyCode;
            esperarATeclaDeSalto = false;
            panel.enabled = false;
        }
    }
    

}
