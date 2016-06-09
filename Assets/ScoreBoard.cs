using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreBoard : MonoBehaviour {

	public static ScoreBoard instance;

	public Text scoreText;


	private int curScore = 0;

	// Use this for initialization
	void Start () {
		ScoreBoard.instance = this;
	}

	public void AddScore(int score) {
		curScore += score;
		scoreText.text = curScore.ToString();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
