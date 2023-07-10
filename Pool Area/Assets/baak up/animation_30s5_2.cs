using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animation_30s5_2 : MonoBehaviour
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
        if (Input.GetKeyDown(KeyCode.UpArrow))
            animator.SetTrigger("attack");
        // Input.GetKey(KeyCode.w)

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
           animator.SetBool("move 0", true);
        else
            animator.SetBool("move 0", false);

        //else if (Input.GetKey(KeyCode.w) || Input.GetKey(KeyCode.s))
        //animator.SetTrigger("move");
    }
    
}
