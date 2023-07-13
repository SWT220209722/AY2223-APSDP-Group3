using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowDestory: MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Target")
            Destroy(gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
