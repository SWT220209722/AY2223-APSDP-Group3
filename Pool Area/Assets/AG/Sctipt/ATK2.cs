using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ATK2 : MonoBehaviour
{
    Animator ani;

    // Start is called before the first frame update
    void Start()
    {
        ani = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Def")
        {
            ani.SetTrigger("Stab");
        }
    }
}
