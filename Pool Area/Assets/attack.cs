using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack : MonoBehaviour
{
    public GameObject attackTem;
    public float offsetTime = 2f;
    private float timer = 0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            
            if (timer > offsetTime)
            {
                timer = 4f;
                attackTem.SetActive(true);
            }

        }
        else {
            timer = 1f;
            timer += Time.deltaTime;
            if (timer < offsetTime)
            {
                timer = 1f;
                attackTem.SetActive(false);
            }
        }
    }
}
