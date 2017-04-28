using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour {

    public Rigidbody2D rb;
    public float ballForce;
    bool GameStarted = false;
    

	// Use this for initialization
	void Awake () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1") && GameStarted == false)
        {
            transform.SetParent(null);
            GameStarted = true;
            rb.isKinematic = false;
            rb.AddForce(new Vector2(ballForce, ballForce));
        }
	}
}
