using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack2 : MonoBehaviour
{
    public GameObject attackTem;
    public float offsetTime = 2f;
    private float timer = 0f;
    private IEnumerator coroutine;

    void Start()
    {

    }

    private IEnumerator Temp()
    {
        yield return new WaitForSeconds(1);
        attackTem.SetActive(false);
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            attackTem.SetActive(true);
            Debug.Log("open");
            StartCoroutine(Temp());
        }
    }
}