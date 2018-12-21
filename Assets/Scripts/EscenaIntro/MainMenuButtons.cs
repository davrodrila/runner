using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuButtons : MonoBehaviour {

    public Button btnPlay, btnOptions, btnExit;

	// Use this for initialization
	void Start () {

        btnPlay.onClick.AddListener(play);
        btnOptions.onClick.AddListener(options);
        btnExit.onClick.AddListener(exit);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void play()
    {
        
    }

    void options()
    {

    }
    void exit()
    {

    }
}
