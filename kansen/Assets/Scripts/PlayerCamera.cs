using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour {

    public GameObject player;
    public float Highest;
    public float Lowest;

	// Use this for initialization
	void Start () {

        
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.position = new Vector3(0,player.transform.position.y,-10);

        if(player.transform.position.y < Lowest) {
            transform.position = new Vector3(0,5,-10);
        }

        if(player.transform.position.y >= Highest) {
            transform.position = new Vector3(0,Highest,-10);
        }
		
	}
}
