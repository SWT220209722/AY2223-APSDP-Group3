using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_object_move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject player1 = GameObjcet.FindGameObjectWithTag("Player");

        gameObject player2 = GameObjcet.FindGameObjectWithTag("Player2");
    }

    // Update is called once per frame
    void Update()
    {
     
    }
}
