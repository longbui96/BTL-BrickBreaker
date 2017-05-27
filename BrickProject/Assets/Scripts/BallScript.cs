using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{

    public UiManager ui;
    public Rigidbody2D rb;
    public float ballForce;
    bool GameStarted = false;

    // Use this for initialization
    void Start()
    {
        ui = GameObject.FindWithTag("ui").GetComponent<UiManager>();
    }

    // Use this for initialization
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && GameStarted == false)
        {
            transform.SetParent(null);
            GameStarted = true;
            rb.isKinematic = false;
            rb.AddForce(new Vector2(ballForce, ballForce));
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.tag == "Paddle")
        {
            ui.combo = 1;
        }

        if (col.gameObject.tag == "Purple")
        {
            ui.row = 5;
        }
        if (col.gameObject.tag == "Red")
        {
            ui.row = 10;
        }
        if (col.gameObject.tag == "Green")
        {
            ui.row = 20;
        }
        if (col.gameObject.tag == "Blue")
        {
            ui.row = 40;
        }
        if (col.gameObject.tag == "Purple" || col.gameObject.tag == "Red" || col.gameObject.tag == "Green" || col.gameObject.tag == "Blue")
        {
            ui.IncrementScore();
            Destroy(col.gameObject);

            ui.combo++;
        }
    }
}
