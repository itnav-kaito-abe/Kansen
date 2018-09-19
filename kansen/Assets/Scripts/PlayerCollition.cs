using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerCollition : MonoBehaviour {

	// Use this for initialization

    GameObject pc;

	void Start () {
		pc = GameObject.Find("baikin_hana");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void GameClear() {
        GameObject GameClear_image = new GameObject("GameClearimage");
        GameClear_image.transform.parent = GameObject.Find("Canvas").transform;
        GameClear_image.AddComponent<RectTransform>().anchoredPosition = new Vector3(0,0,-10);
        GameClear_image.GetComponent<RectTransform>().localScale = new Vector3(1,1,1);
        GameClear_image.AddComponent<Image>().sprite = Resources.Load<Sprite>("Images/UI/Combat/clear&nextstage");
        GameClear_image.GetComponent<Image>().preserveAspect = true;
        GameClear_image.GetComponent<Image>().SetNativeSize();
        CircleCollider2D Collition = GameObject.Find("baikin_hana").gameObject.GetComponent<CircleCollider2D>();
        CircleCollider2D Outside = GameObject.Find("baikin_hana").gameObject.transform.Find("Collition").gameObject.GetComponent<CircleCollider2D>();
        Destroy(Collition);
        Destroy(Outside);

        pc.SetActive(false);
     }

    public void GameOver() {
        GameObject GameOver_image = new GameObject("GameOverimage");
        GameOver_image.transform.parent = GameObject.Find("Canvas").transform;
        GameOver_image.AddComponent<RectTransform>().anchoredPosition = new Vector3(0,0,-10);
        GameOver_image.GetComponent<RectTransform>().localScale = new Vector3(1,1,1);
        GameOver_image.AddComponent<Image>().sprite = Resources.Load<Sprite>("Images/UI/Combat/gameover");
        GameOver_image.GetComponent<Image>().preserveAspect = true;
        GameOver_image.GetComponent<Image>().SetNativeSize();
        CircleCollider2D Collition = GameObject.Find("baikin_hana").gameObject.GetComponent<CircleCollider2D>();
        CircleCollider2D Outside = GameObject.Find("baikin_hana").gameObject.transform.Find("Collition").gameObject.GetComponent<CircleCollider2D>();
        Destroy(Collition);
        Destroy(Outside);

        pc.SetActive(false);
    }

    public void GoSelect() {
    SceneManager.LoadScene("Select");
    }

    public void GoSelect_Bard() {
    SceneManager.LoadScene("Select_Bard");
    }

    public void GoSelect_Cat() {
    SceneManager.LoadScene("Select_Cat");
    }

    public void GoSelect_Human() {
    SceneManager.LoadScene("Select_Human");
    }

    public void GoTitle() {
    SceneManager.LoadScene("Title");
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.tag == "GE") {
                GameOver();
                Invoke("GoSelect",1.5f);
        }

        if(collision.gameObject.tag == "BE") {
                GameOver();
                Invoke("GoSelect_Bard",1.5f);
        }

        if(collision.gameObject.tag == "CE") {
                GameOver();
                Invoke("GoSelect_Cat",1.5f);
        }

        if(collision.gameObject.tag == "HE") {
                GameOver();
                Invoke("GoSelect_Human",1.5f);
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {

        if(other.gameObject.tag == "GB") {
                GameClear();
                Invoke("GoSelect_Bard",1.5f);
        }

        if(other.gameObject.tag == "GBullet") {
                GameOver();
                Invoke("GoSelect",1.5f);
        }

        if(other.gameObject.tag == "BBullet") {
                GameOver();
                Invoke("GoSelect_Bard",1.5f);
        }

        if(other.gameObject.tag == "BB") {
                GameClear();
                Invoke("GoSelect_Cat",1.5f);
        }

        if(other.gameObject.tag == "CBullet") {
                GameOver();
                Invoke("GoSelect_Cat",1.5f);
        }

        if(other.gameObject.tag == "CB") {
                GameClear();
                Invoke("GoSelect_Human",1.5f);       
        }

        if(other.gameObject.tag == "HBullet") {
                GameOver();
                Invoke("GoSelect_Human",1.5f);
        }

        if(other.gameObject.tag == "HB") {
                GameClear();
                Invoke("GoTitle",1.5f);
        }
    }
}
