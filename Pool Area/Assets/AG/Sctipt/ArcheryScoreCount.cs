using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ArcheryScoreCount : MonoBehaviour {

	public static int P1score;
	public static Text P1scoreText;

	void Start () {
		PlayerPrefs.DeleteAll();
		P1scoreText = GetComponent<Text>();
		Debug.Log("1");
		P1score = PlayerPrefs.GetInt("Player 1", 0);
		Debug.Log("0");
		UpdateScore(1, 0);
	}
	
	public static void UpdateScore(int PID, int value) {
			P1score += value;
			Debug.Log(P1score);
			PlayerPrefs.SetInt("Player 1", P1score);
			Debug.Log(PlayerPrefs.GetInt("Player 1", 1));
			PlayerPrefs.Save();
			P1scoreText.text= "Score: " + P1score.ToString();
		/*else if (PID == 2){
			P2score += value;
			PlayerPrefs.SetInt("Player 2", P2score);
			PlayerPrefs.Save();
			P2scoreText.text = "Score: " + P2score.ToString();
		}*/
	}

	void Update(){
		
	}
}



