using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class UiManager : MonoBehaviour {

	public int score = 0;
    int bricks = 24;
    int lives = 3;
    public int combo;
    public int row;
	public Text scoreText;
    public Text LivesText;
    public GameObject Paddle;
    public GameObject BallOut;
    public GameObject GameOver;
    public GameObject YouWon;
    public GameObject BottomWall;

    private GameObject ClonePaddle;
    private GameObject CloneBallOut;

	// Use this for initialization
	void Start () {
        combo = 1;
        row = 0;
        Setup();
    }

    void Setup()
    {
        ClonePaddle = Instantiate(Paddle, Paddle.transform.position, Quaternion.identity);
        Destroy(CloneBallOut);
    }

    private void Reset()
    {
        Application.LoadLevel(Application.loadedLevel);
    }

    // Update is called once per frame
    void Update () {
	
	}

    void CheckOver()
    {
        if (lives < 1)
        {
            GameOver.SetActive(true);
            Invoke("Reset",3f);
        }
        else if (bricks < 1)
        {
            YouWon.SetActive(true);
            BottomWall.SetActive(true);
            Invoke("Reset",3f);
        }
    }

	public void IncrementScore(){
        score += combo + row;
        bricks--;
		scoreText.text = "Score: " + score;
        CheckOver();
	}

    public void OutBall()
    {
        lives--;
        LivesText.text = "Lives: " + lives;
        Destroy(ClonePaddle);
        CheckOver();
        CloneBallOut = Instantiate(BallOut, Paddle.transform.position, Quaternion.identity);
        Invoke("Setup", 3f);
    }
}
