using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turn : MonoBehaviour
{
    //Creates a variable which will decide how fast the platform will spin
    float speed = 50.0f;

    // Update is called once per frame
    void Update()
    {
        //Turns the platform with the speed 50
        transform.Rotate(Vector3.back * speed * Time.deltaTime);
    }
}
