using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GotHit_anim : MonoBehaviour
{
    int timer_i =0;
    bool start_Timer=true;
    public Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }
    IEnumerator timer(){
        yield return new WaitForSeconds(1);
        timer_i++;
        start_Timer=true;
      //  animator.SetBool("GotHit",true);    
    }
    // Update is called once per frame
    void Update()
    {
     if(start_Timer){
            StartCoroutine("timer");
            start_Timer=false;
            Debug.Log(timer_i);
        }
    }
}
