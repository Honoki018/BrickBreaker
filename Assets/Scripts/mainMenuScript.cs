using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class mainMenuScript : MonoBehaviour {
	public Text scoreText;
	// Use this for initialization
	void Start () {
		scoreText.text = PlayerPrefs.GetInt("highScore", 0).ToString();
	}

	public void startGame(){
		Application.LoadLevel(1);
	}
}
