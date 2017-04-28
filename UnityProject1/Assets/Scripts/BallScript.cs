using UnityEngine;
using System.Collections;

public class BallScript : MonoBehaviour {

	public Rigidbody2D rb;
	public float ballForce;
	bool gameStarted = false;
    public Transform BallChecker;
    //public AudioSource reset;
    // Use this for initialization
    void Start () {
        rb.AddForce(new Vector2(ballForce, ballForce));
	}
	
	// Update is called once per frame
	void Update () {

		if( Input.GetKeyUp(KeyCode.Space) && gameStarted == false ){

			transform.SetParent (null);
			rb.isKinematic = false;

			rb.AddForce (new Vector2 (ballForce, ballForce));
			gameStarted = true;

		}
        if(Input.GetKey (KeyCode.Space))
        {
            rb.AddForce(new Vector2(1f, 0.5f) * Time.deltaTime * ballForce);
        }
        if(transform.position.y < BallChecker.transform.position.y)
        {

            Application.LoadLevel(Application.loadedLevel);
        }

	}
		
}
