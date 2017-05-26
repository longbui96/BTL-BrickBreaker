using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZone : MonoBehaviour {

    public UiManager ui;

	// Use this for initialization
	void Start () {
        ui = GameObject.FindWithTag("ui").GetComponent<UiManager>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D col)
    {
        ui.OutBall();
    }
}
