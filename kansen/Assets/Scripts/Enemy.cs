using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public GameObject EnemyBullet;
    public float missilespeed;
    public int timeCount = 0;
    public float x;
    public float y;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        timeCount += 1;

        


        if(timeCount % 60 == 0) {

            GameObject enemybullet = Instantiate(EnemyBullet,transform.position,Quaternion.identity) as GameObject;
            Rigidbody2D enemyrb = enemybullet.GetComponent<Rigidbody2D>();
            enemyrb.velocity = new Vector2(x,y)*missilespeed;
            Destroy(enemybullet,2.0f);
        }
		
	}
}
