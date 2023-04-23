using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GotHit : MonoBehaviour
{
    public GameObject hitFX;
    public AudioClip hitsound;
    public int EnmPID;

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
            if (EnmPID == 1) {
                Debug.Log("Atk Pt + 1");
                ScoreCount1.UpdateScore(1, 1);

                audiosource.PlayOneShot(hitsound);
                Debug.Log("sfx played");
                //Instantiate (hitFX, col.contacts[0].point, Quaternion.identity);
                Debug.Log("hitfx played");
            } else if (EnmPID == 2)
            {
                Debug.Log("Atk Pt + 1");
                ScoreCount2.UpdateScore(2, 1);

                audiosource.PlayOneShot(hitsound);
                Debug.Log("sfx played");
                //Instantiate (hitFX, col.contacts[0].point, Quaternion.identity);
                Debug.Log("hitfx played");
            }
        }
    }

    void OnCollisionExit(Collision col)
    {
        Counter(col);
    }


    void Counter(Collision col) {
        double Ctime = 5;
        
        if (Ctime > 0)
        {
            //Debug.Log(Ctime);
            if (Input.GetButton("Fire2"))
            {
                Debug.Log(Ctime);
                Debug.Log("CS");
                Ctime = 0;
                Debug.Log(Ctime);
            }
            else
            {
                Ctime -= Time.deltaTime;
            }

            //Debug.Log("CS1");
        }
    }
}
