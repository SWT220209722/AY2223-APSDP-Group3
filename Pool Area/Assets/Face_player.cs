using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Face_player : MonoBehaviour
{
    public GameObject player2;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        transform.LookAt(player2.transform);
    }
}
