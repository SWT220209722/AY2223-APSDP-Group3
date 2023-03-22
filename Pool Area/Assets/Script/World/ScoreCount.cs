﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreCount : MonoBehaviour {

	public static int score;
	public static Text scoreText;
	public GameObject P1Win;
	public float WinCon;

	void Start () {
		PlayerPrefs.DeleteAll();
		scoreText = GetComponent<Text>();
		score = PlayerPrefs.GetInt("scoreData",0);
		UpdateScore (0);
	}
	
	public static void UpdateScore(int value) {
		score += value;
		PlayerPrefs.SetInt("scoreData", score);
		PlayerPrefs.Save();
		scoreText.text= "Score: " + score.ToString();
	}

	void Update(){
		if (score == WinCon) {
			P1Win.SetActive(true);
			Time.timeScale = 0;
		}
	}
}



