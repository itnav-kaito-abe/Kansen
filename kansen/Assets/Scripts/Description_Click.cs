using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Description_Click : MonoBehaviour {

    GameObject Description;
    GameObject Next_Scene;
    GameObject Back_Scene;


	// Use this for initialization
	void Start () {
        Description = GameObject.Find("Canvas").transform.Find("Description").gameObject;
        Description.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Display() {
        Next_Scene = GameObject.Find("Canvas").transform.Find("Next_Scene").gameObject;
        Back_Scene = GameObject.Find("Canvas").transform.Find("Back_Scene").gameObject;
        Description = GameObject.Find("Canvas").transform.Find("Description").gameObject;
        Next_Scene.SetActive(false);
        Back_Scene.SetActive(false);
        Description.SetActive(true);
    }

    public void Hide() {
        Next_Scene = GameObject.Find("Canvas").transform.Find("Next_Scene").gameObject;
        Back_Scene = GameObject.Find("Canvas").transform.Find("Back_Scene").gameObject;
        Description = GameObject.Find("Canvas").transform.Find("Description").gameObject;
        Next_Scene.SetActive(true);
        Back_Scene.SetActive(true);
        Description.SetActive(false);
    }

    public void Imo_Display() {
        Next_Scene = GameObject.Find("Canvas").transform.Find("Next_Scene").gameObject;
        Description = GameObject.Find("Canvas").transform.Find("Description").gameObject;
        Next_Scene.SetActive(false);
        Description.SetActive(true);
    }

    public void Imo_Hide() {
        Next_Scene = GameObject.Find("Canvas").transform.Find("Next_Scene").gameObject;
        Description = GameObject.Find("Canvas").transform.Find("Description").gameObject;
        Description.SetActive(false);
        Next_Scene.SetActive(true);
    }

    public void Human_Display() {
        Back_Scene = GameObject.Find("Canvas").transform.Find("Back_Scene").gameObject;
        Description = GameObject.Find("Canvas").transform.Find("Description").gameObject;
        Back_Scene.SetActive(false);
        Description.SetActive(true);
    }

    public void Human_Hide() {
        Back_Scene = GameObject.Find("Canvas").transform.Find("Back_Scene").gameObject;
        Description = GameObject.Find("Canvas").transform.Find("Description").gameObject;
        Description.SetActive(false);
        Back_Scene.SetActive(true);
    }
}
