using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader:MonoBehaviour
{
    public Animator transition;

    // Update is called once per frame
    void Update()
    {

    }

    public void LoadLevel1()
    {
        StartCoroutine(LoadLevel("Level 1"));
    }

    public void LoadArcherGame()
    {
        StartCoroutine(LoadLevel("Archer Game"));
    }

    IEnumerator LoadLevel(string levelName)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(1f);

        SceneManager.LoadScene(levelName);
    }
}
