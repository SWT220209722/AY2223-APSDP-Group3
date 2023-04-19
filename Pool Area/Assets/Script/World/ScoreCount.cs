using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreCount : MonoBehaviour {

	public static int P1score;
	public static int P2score;
	public static Text scoreText;
	public GameObject P1WinningPlayer;
	public GameObject P2WinningPlayer;
	public int WinCon;
	public Slider P1_HP_Bar;
	public Slider P2_HP_Bar;

	void Start () {
		PlayerPrefs.DeleteAll();
		scoreText = GetComponent<Text>();
		P1score = PlayerPrefs.GetInt("Player 1", 0);
		P2score = PlayerPrefs.GetInt("Player 2", 0);
		UpdateScore(1, 0);
		UpdateScore(2, 0);
		P1_HP_Bar.maxValue = 10;
		P2_HP_Bar.maxValue = (WinCon - 1);
		P1_HP_Bar.minValue = 0;
		P2_HP_Bar.minValue = 0;
	}
	
	public static void UpdateScore(int PID, int value) {
		if (PID == 1){
			P1score += value;
			Debug.Log(P1score);
			PlayerPrefs.SetInt("Player 1", P1score);
			Debug.Log(PlayerPrefs.GetInt("Player 1", 1));
			PlayerPrefs.Save();
			scoreText.text= "Score: " + P1score.ToString();
		}
		else if (PID == 2){
			P2score += value;
			PlayerPrefs.SetInt("Player 2", P2score);
			PlayerPrefs.Save();
			scoreText.text = "Score: " + P2score.ToString();
		}
	}

	void Update(){
		if (P1score == WinCon) {
			Time.timeScale = 0;
			P1WinningPlayer.SetActive(true);
		} else if (P2score == WinCon) {
			Time.timeScale = 0;
			P2WinningPlayer.SetActive(true);
		}
		P1_HP_Bar.value = P1score;
		P2_HP_Bar.value = P2score;
	}
}



