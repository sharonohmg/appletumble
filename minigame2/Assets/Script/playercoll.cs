using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercoll : MonoBehaviour {

    public Player movement;
 

    void OnCollisionEnter(Collision touch)
    {
        if (touch.collider.tag=="Obs") {
            movement.enabled = false;
            FindObjectOfType<gamemanager>().EndGame();
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
