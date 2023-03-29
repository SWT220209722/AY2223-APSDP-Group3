using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_object : MonoBehaviour
{

    public GameObject P1;
    public GameObject P2;
    public float Distance_camera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        Distance_camera = Vector3.Distance(P1.transform.position, P2.transform.position);
        if (Distance_camera > 7.5f)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, Distance_camera);
        }
    }
}