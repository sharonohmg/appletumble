﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endtrigger : MonoBehaviour {

    public gamemanager gameManager;

    void OnTriggerEnter()
    {
        gameManager.CompleteLevel();
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
