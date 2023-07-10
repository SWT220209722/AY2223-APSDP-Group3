using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement_player2 : MonoBehaviour
{
 private Vector3 playerVelocity;
 private float speed = 5.0f;
 public GameObject jo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        transform.Translate(Vector3.forward * (0.7f*speed) * Time.deltaTime);
        if(Input.GetKey(KeyCode.RightArrow)){
        transform.Translate(Vector3.forward * (-0.5f*speed) * Time.deltaTime);
        }
        transform.position = new Vector3(jo.transform.position.x,jo.transform.position.y,9.85f);
        
    }
}
