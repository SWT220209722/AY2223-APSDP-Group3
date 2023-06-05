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
        if (Input.GetKey(KeyCode.O))
            animator.SetTrigger("attack");
        // Input.GetKey(KeyCode.w)

        if (Input.GetButton("Vertical2") || Input.GetButton("Horizontal2"))
           animator.SetBool("move 0", true);
        else
            animator.SetBool("move 0", false);

        //else if (Input.GetKey(KeyCode.w) || Input.GetKey(KeyCode.s))
        //animator.SetTrigger("move");
    }
    
}
