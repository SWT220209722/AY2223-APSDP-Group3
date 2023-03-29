using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GotHit : MonoBehaviour
{
    public GameObject hitFX;
    public AudioClip hitsound;
    private float Rtime = 0;

    AudioSource audiosource;


    // Start is called before the first frame update
    void Start()
    {
        audiosource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
        /*if (col.gameObject.tag == "Swd")
        {
            Debug.Log("Swd Pt + 1");
            ScoreCount.UpdateScore(1);
        }
        else*/ if (col.gameObject.tag == "Swd")
        {
            if (Rtime < 2) {
                Debug.Log("Atk Pt + 1");
                ScoreCount.UpdateScore(1);

                audiosource.PlayOneShot(hitsound);
                Debug.Log("sfx played");
                //Instantiate (hitFX, col.contacts[0].point, Quaternion.identity);
                Debug.Log("hitfx played");
                Counter(col);
                for (int i = 0; i < 100; i++)
                {
                    Rtime += Time.deltaTime;
                }
            }

        }
    }

    void Counter(Collision col) {
        float Ctime = 0;
        for (int i = 0; i <= 75 ; i++) {
            Debug.Log(Ctime);
            Ctime += Time.deltaTime;
            /*if (Ctime <= 1.5 && col.gameObject.tag == "Swd") {
                Debug.Log("D scs");
            }*/
            if (col.gameObject.tag == "Swd")
            {
                Debug.Log("scs");
                continue;
            }
        }
        Debug.Log(Ctime);
        if (Ctime<=1.5) {
            Debug.Log("D scs");
        }
    }
}
