using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleScript : MonoBehaviour {

    public Rigidbody2D rb;
    public float speed;
    public float Xmax;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float x = Input.GetAxis("Mouse X");
        
        if (x < 0)
            MoveLeft();
        if (x > 0)
            MoveRight();
        if (x == 0)
            Stop();
        Vector2 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x,-Xmax,Xmax);
        transform.position = pos;
        
	}

    void MoveLeft()
    {
        rb.velocity = new Vector2(-speed, 0);
    }

    void MoveRight()
    {
        rb.velocity = new Vector2(speed, 0);
    }

    void Stop()
    {
        rb.velocity = Vector2.zero;
    }

    
}
