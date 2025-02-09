﻿	using UnityEngine;
using System.Collections;

public class PaddleScript : MonoBehaviour {

	public Rigidbody2D rb;
	public float speed;
	public float maxX;
    public AudioSource ting;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float x = Input.GetAxis ("Horizontal");

		if (x < 0) {
			MoveLeft ();
            ting.Play();
        }

		if (x > 0) {
			MoveRight ();
            ting.Play();
        }

		if (x == 0) {
			Stop ();
            ting.Play();
        }

		Vector3 pos = transform.position;
		pos.x = Mathf.Clamp (pos.x,-maxX,maxX);
		transform.position = pos;
        ting.Play();
	}

	void MoveLeft(){
		rb.velocity = new Vector2 (-speed,0);
        ting.Play();
    }

	void MoveRight(){
		
		rb.velocity = new Vector2 (speed,0);
        ting.Play();
    }

	void Stop(){
		rb.velocity = Vector2.zero;
        ting.Play();
    }


}
