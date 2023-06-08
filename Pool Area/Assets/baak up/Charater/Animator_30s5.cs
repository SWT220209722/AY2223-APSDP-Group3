using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animator_30s5 : MonoBehaviour
{
  public Animator animator;

    
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.R))
            animator.SetTrigger("attack");
        // Input.GetKey(KeyCode.w)

        if (Input.GetKey(KeyCode.D))
           animator.SetBool("move 0", true);
        else
            animator.SetBool("move 0", false);
        if(Input.GetKey(KeyCode.A))
        animator.SetBool("back",true);
        else
            animator.SetBool("back",false);
        //else if (Input.GetKey(KeyCode.w) || Input.GetKey(KeyCode.s))
        //animator.SetTrigger("move");
    }
    
}
