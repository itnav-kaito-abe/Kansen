using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Description_Click : MonoBehaviour {

    GameObject Description;

	// Use this for initialization
	void Start () {
        Description = GameObject.Find("Canvas").transform.Find("Description").gameObject;
        Description.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Display() {
        Description = GameObject.Find("Canvas").transform.Find("Description").gameObject;
        Description.SetActive(true);
    }

    public void Hide() {
        Description = GameObject.Find("Canvas").transform.Find("Description").gameObject;
        Description.SetActive(false);
    }
}
