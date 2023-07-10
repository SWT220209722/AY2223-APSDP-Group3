using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreCount2 : MonoBehaviour {

	public static int P2score;
	public static Text P2scoreText;
	//public GameObject P1WinningPlayer;
	public GameObject P2WinningPlayer;
	public GameObject Panel;
	public int WinCon;
	public Slider P2_HP_Bar;

	void Start () {
		PlayerPrefs.DeleteAll();
		P2scoreText = GetComponent<Text>();
		P2score = PlayerPrefs.GetInt("Player 2", 0);
		UpdateScore(2, 0);
		P2_HP_Bar.maxValue = (WinCon - 1);
		P2_HP_Bar.minValue = 0;
	}
	
	public static void UpdateScore(int PID, int value) {
		/*if (PID == 1){
			P1score += value;
			Debug.Log(P1score);
			PlayerPrefs.SetInt("Player 1", P1score);
			Debug.Log(PlayerPrefs.GetInt("Player 1", 1));
			PlayerPrefs.Save();
			P1scoreText.text= "Score: " + P1score.ToString();
		}
		else */if (PID == 2){
			P2score += value;
			PlayerPrefs.SetInt("Player 2", P2score);
			PlayerPrefs.Save();
			P2scoreText.text = "P2 Score: " + P2score.ToString();

		}
	}

	void Update(){
		/*if (P1score == WinCon) {
			Time.timeScale = 0;
			//P1WinningPlayer.SetActive(true);
		} else */if (P2score == WinCon) {
			Time.timeScale = 0;
			P2WinningPlayer.SetActive(true);
			Panel.SetActive(true);
		}
		//P1_HP_Bar.value = P1score;
		P2_HP_Bar.value = P2score;
	}
}



