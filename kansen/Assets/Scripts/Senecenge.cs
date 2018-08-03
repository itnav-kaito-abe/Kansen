using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Senecenge : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


	}

    public void ToSelectScene() {
        SceneManager.LoadScene("Select");
    }

    public void Selecte() {
        Invoke("ToSelectScene",0.1f);
    }

    public void ToGreencaterpillar(){
        SceneManager.LoadScene("Green caterpillar");
    }

    public void Selecte_G() {
        Invoke("ToGreencaterpillar",0.1f);
    }

    public void ToBard() {
        SceneManager.LoadScene("Bard");
    }

    public void Selecte_B() {
        Invoke("ToBard",0.1f);
    }

    public void ToCat() {
        SceneManager.LoadScene("Cat");
    }

    public void Selecte_C() {
        Invoke("ToCat",0.1f);
    }

    public void ToHuman() {
        SceneManager.LoadScene("Human");
    }

    public void Selecte_H() {
        Invoke("ToHuman",0.1f);
    }

}
