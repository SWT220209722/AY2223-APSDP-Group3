using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_object : MonoBehaviour
{
    
    public GameObject P1;
    public GameObject P2;
    public GameObject B1;
    public GameObject B2;
    public float newcamera_z;
    public float Distance_camera;
    public float angle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Distance_camera = (P1.transform.position.x + P2.transform.position.x)/2;
        newcamera_z = Distance_camera * Mathf.Tan(angle)+10;
        if (newcamera_z<=7.7)
            newcamera_z=7.7f;
        else if (newcamera_z>=10)
            newcamera_z= 10;
        transform.position = new Vector3(Distance_camera, 2.53f, newcamera_z);
        
    }
}