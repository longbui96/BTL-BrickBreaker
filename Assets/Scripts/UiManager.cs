using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class UiManager : MonoBehaviour {

	int score = 0;
    int bricks = 24;
    int lives = 3;
	public Text scoreText;
    public Text LivesText;
    public GameObject Paddle;
    public GameObject BallOut;
    public GameObject GameOver;
    public GameObject YouWon;

    private GameObject ClonePaddle;
    private GameObject CloneBallOut;

	// Use this for initialization
	void Start () {
        Setup();
    }

    void Setup()
    {
        ClonePaddle = Instantiate(Paddle, Paddle.transform.position, Quaternion.identity);
        Destroy(CloneBallOut);
    }

	// Update is called once per frame
	void Update () {
	
	}

	public void IncrementScore(){
		score++;
        bricks--;
		scoreText.text = "Score: " + score;
	}

    public void OutBall()
    {
        lives--;
        LivesText.text = "Lives: " + lives;
        Destroy(ClonePaddle);
        CloneBallOut = Instantiate(BallOut, Paddle.transform.position, Quaternion.identity);
        Invoke("Setup", 3f);
    }
}
