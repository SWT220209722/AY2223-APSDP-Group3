using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PauseMenu1 : MonoBehaviour {

public GameObject pauseMenu;

void Update()
{
    if (Input.GetKeyDown(KeyCode.Escape))
    {
       PauseGame (); // Pause the game by setting the time scale to 0
		
    }

    if (Input.GetKeyDown(KeyCode.Space))
    {
        ResumeGame (); // Resume the game by setting the time scale back to 1
    }
}

	public void PauseGame () {
		Time.timeScale = 0;
		//PauseMenu1.SetActive(true);
	}

	public void ResumeGame () {
		Time.timeScale = 1;
		//PauseMenu1.SetActive(false);
	}

	public void ExitGame () {
		Time.timeScale = 1;
		SceneManager.LoadScene("MainMenu");

		if(Input.GetKeyDown(KeyCode.L))
			Application.Quit();
	}
}
