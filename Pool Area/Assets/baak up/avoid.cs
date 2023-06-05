using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class avoid : MonoBehaviour
{
public GameObject P1;
public GameObject P2;
public Animator animator;
public float playerX;
public float playerZ;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
    playerX =P1.transform.position.x ;
   playerZ = P2.transform.position.z ;
        if(Input.GetKey(KeyCode.G)){
        animator.SetBool("avoid", true);
        transform.position = new Vector3(playerX,3.18f,playerZ);
        }
        else
        animator.SetBool("avoid",false);
        if(P1.transform.position.y < 3.14f)
         transform.position = new Vector3(playerX,3.18f,playerZ);
    }
}
