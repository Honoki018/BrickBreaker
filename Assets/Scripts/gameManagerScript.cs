using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class gameManagerScript : MonoBehaviour {
	public GameObject paddlePrefab;
	public GameObject capsulePrefab;
	public GameObject particlePrefab;
	public Vector3 paddleInstantiatePosition = new Vector3(0f, -10f, 0);
	public Text scoreText;
	public int score = 0;
	private int lastTime=0;

	void Start(){
		Screen.sleepTimeout = SleepTimeout.NeverSleep;
		instantiatePaddle();
	}

	void Update(){
		if((int)Time.time % 1 == 0 && (int)Time.time != lastTime){
			Instantiate(capsulePrefab, new Vector3(Random.Range(-7.5f, 7.5f), 15f, 0), capsulePrefab.transform.rotation);
			lastTime = (int)Time.time;
		}
	}

	public void scoreChange(){
		score++;
		scoreText.text = score.ToString();
	}

	public void gameOver(){
		if(score > PlayerPrefs.GetInt("highScore", 0)){
			PlayerPrefs.SetInt("highScore", score);
		}
		GameObject[] playerPaddle = GameObject.FindGameObjectsWithTag("Player");
		GameObject[] playerBall = GameObject.FindGameObjectsWithTag("ball");
		foreach(GameObject player in playerPaddle){
			Destroy(player);
		}
		foreach(GameObject ball in playerBall){
			Destroy(ball);
		}
		instantiatePaddle();
		playerPaddle = null;
		playerBall = null;
		score = 0;
		scoreText.text = score.ToString();
	}

	public void instantiatePaddle(){
		Instantiate(paddlePrefab, paddleInstantiatePosition, Quaternion.identity);
	}

	public void backToMenu(){
		Application.LoadLevel(0);
	}
}
